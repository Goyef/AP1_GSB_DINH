using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AP1_GSB_DINH
{
    public partial class AjoutHorsForfait : Form
    {
        int idUser = 0;
        int idFiche = 0;
        private Service db = new Service();
        public AjoutHorsForfait(int IdUser)
        {
            idUser = IdUser;
            InitializeComponent();
        }



        private void FixLimitDate()
        {
            DateTime now = DateTime.Now;
            string min;
            if (now.Day < 11)
            {
                now = now.AddMonths(-1);
            }

            min = $"11 {now.Month} {now.Year}";
            DateTime Min = DateTime.Parse(min);
            DateTime Max = Min.AddMonths(1);
            Max = Max.AddDays(-1);

            Calendar.MinDate = Min;
            Calendar.MaxDate = Max;
        }

        private void ReturnBt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AjoutBt_Click(object sender, EventArgs e)
        {
            string sum = SumInput.Text;
            if (DescInput.Text == "")
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
                    GetIdFiche();
                    // Ajout à la base
                    using (MySqlCommand cmd = new MySqlCommand("INSERT INTO `frais_hors_forfait`(`nom`, `montant`, `date`, `id_fiche`) VALUES (@nom, @montant, @date, @idFiche);", conn))
                    {
                        cmd.Parameters.AddWithValue("@nom", DescInput.Text);
                        cmd.Parameters.AddWithValue("@montant", sum);
                        cmd.Parameters.AddWithValue("@date", db.ConvertDateFormat(Calendar.Value));
                        cmd.Parameters.AddWithValue("@idFiche", idFiche);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Un nouvel élément a bien été ajouté");
                    }
                    conn.Close();
                    db.UpdateData(idFiche);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Il y a eu un probleme avec la base de donnée, veuillez recommencez");
                }
            }
        }

        private void SumInput_KeyPress(object sender, KeyPressEventArgs e)
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

        private void AjoutHorsForfait_Load(object sender, EventArgs e)
        {
            FixLimitDate();
        }

        private int GetIdFiche()
        {
            // Acces à la bonne fiche
            using (MySqlConnection conn = db.GetConnection())
            {
                if (conn != null)
                {
                    string datemy = db.DateFiche();
                    using (MySqlCommand command = new MySqlCommand("SELECT id_fiche FROM fiche_frais LEFT JOIN utilisateur On utilisateur.id_utilisateur = fiche_frais.id_utilisateur " +
                        "WHERE fiche_frais.id_utilisateur = @idUser AND fiche_frais.annee_mois = @datemy", conn))
                    {
                        command.Parameters.AddWithValue("@idUser", idUser);
                        command.Parameters.AddWithValue("@datemy", datemy);
                        idFiche = Convert.ToInt32(command.ExecuteScalar());
                        conn.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Il y a eu un probleme avec la base de donnée, veuillez recommencez");
                }
                return idFiche;
            }
        }

     
    }
}
