using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP1_GSB_DINH.Forms.Administrateur
{
    public partial class ModalGestionFrais : Form
    {
        Service db = new Service();
        string fonction; 
        public ModalGestionFrais(string Fonction)
        {
            InitializeComponent();
            fonction = Fonction;
        }

        private void ModalGestionFrais_Load(object sender, EventArgs e)
        {
            if (fonction == "A")
            {
                InputLabel.Visible = true;
                InputLabel.Enabled = true;
                UserInput.Visible = true;
                UserInput.Enabled=true;
                ModAjout.Text = "Ajouter";
            }
            else if (fonction == "M")
            {
                SelectLabel.Visible = true;
                SelectLabel.Enabled = true;
                UserSelect.Visible = true;
                UserSelect.Enabled=true;
                ModAjout.Text = "Modifier";
                using (MySqlConnection conn = db.GetConnection())
                {
                    if (conn != null)
                    {
                        using (MySqlCommand cmd = new MySqlCommand("SELECT type FROM `grille_tarif`;", conn))
                        {
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                DataTable dt = new DataTable();
                                dt.Columns.Add("type", typeof(string));
                                dt.Load(reader);
                                UserSelect.ValueMember = "type";
                                UserSelect.DataSource = dt;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Il y a eu un problème avec la base de donnée, veuillez recommencez");
                    }
                }
            }
        }
        private void SommeInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 44 && SumInput.Text.IndexOf(',') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!Char.IsDigit(ch) && ch != 8 && ch != 44)
            {
                e.Handled = true;

            }
        }

        private void ExitBt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ValidateBt_Click(object sender, EventArgs e)
        {
            if (fonction == "A")
                AddFrais();
            else if (fonction == "M")
                EditFrais();
        }
        private void EditFrais()
        {
            string sum = SumInput.Text;
            if (float.TryParse(sum, out float value))
            {
                value = (float)System.Math.Round(value, 3);
                sum = value.ToString().Replace(',', '.');
            }
            else
            {
                MessageBox.Show("La valeur saisie n'est pas au bon format");
                SumInput.Clear();
                return;
            }
            using (MySqlConnection conn = db.GetConnection())
            {
                {
                    if (conn != null)
                    {
                        using (MySqlCommand command = new MySqlCommand("UPDATE `grille_tarif` SET montant = @sum WHERE type = @type;", conn))
                        {
                            command.Parameters.AddWithValue("@sum", sum);
                            command.Parameters.AddWithValue("type", UserSelect.Text);
                            command.ExecuteNonQuery();
                            MessageBox.Show($"L'élément {UserSelect.Text} a bien eu sa valeur modifié");
                            conn.Close();
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Il y a eu un problème avec la base de donnée, veuillez recommencez");
                    }
                }
            }
        }
        private void AddFrais()
        {
            string sum = SumInput.Text;
            if (UserInput.Text == "")
            {
                MessageBox.Show("Veuillez saisir une description");
                return;
            }
            if (float.TryParse(sum, out float value))
            {
                value = (float)System.Math.Round(value, 3);
                sum = value.ToString().Replace(',', '.');
            }
            else
            {
                MessageBox.Show("La valeur saisie n'est pas au bon format");
                SumInput.Clear();
                return;
            }
            using (MySqlConnection conn = db.GetConnection())
            {
                if (conn != null)
                {
                    using (MySqlCommand comd = new MySqlCommand("INSERT INTO `grille_tarif`(`type`, `montant`) VALUES " +
                        "(@type, @montant);", conn))
                    {
                        comd.Parameters.AddWithValue("@type", UserInput.Text);
                        comd.Parameters.AddWithValue("@montant", sum);
                        comd.ExecuteNonQuery();
                        MessageBox.Show("Un nouvel élément a bien été ajouté");
                    }
                    conn.Close();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Il y a eu un problème avec la base de donnée, veuillez recommencez");
                }
            }
        }

        private void UserSelect_TextChanged(object sender, EventArgs e)
        {
            string montant;
            using (MySqlConnection conn = db.GetConnection())
            {
                using (MySqlCommand command = new MySqlCommand("SELECT montant FROM grille_tarif WHERE type = @type", conn))
                {
                    command.Parameters.AddWithValue("@type", UserSelect.Text);
                    montant = float.Parse(command.ExecuteScalar().ToString()).ToString();
                    SumInput.Text = montant ;
                    conn.Close();
                }
            }
        }
    }
}
