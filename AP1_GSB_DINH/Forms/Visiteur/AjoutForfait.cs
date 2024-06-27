using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace AP1_GSB_DINH
{
    public partial class AjouterForfait : Form
    {
        int idUser = 0;
        int idFiche = 0;
        private Service db = new Service();
        int idTarif;
        public AjouterForfait(int IdUser)
        {
            idUser = IdUser;
            InitializeComponent();
        }



        private void ReturnBt_Click(object sender, EventArgs e)
        {
            this.Close();
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


        private void AjouterForfait_Load(object sender, EventArgs e)
        {
            FixLimitDate();
            using (MySqlConnection conn = db.GetConnection())
            {
                if (conn != null)
                {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM `grille_tarif`;", conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            //chargement des types
                            DataTable dt = new DataTable();
                            dt.Columns.Add("type", typeof(string));
                            dt.Load(reader);
                            TypeSelect.ValueMember = "type";
                            TypeSelect.DataSource = dt;
                        }
                    }
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Il y a eu un probleme avec la base de donnée, veuillez recommencez");
                }
            }

        }

        private void AjoutBt_Click(object sender, EventArgs e)
        {
            string prix ="";
            float montant;
            int qty = Convert.ToInt32(QuantiteInput.Value);
            GetIdFiche();

            using (MySqlConnection conn = db.GetConnection())
            {
                if (conn != null)
                {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT grille_tarif.id_tarif, grille_tarif.montant FROM grille_tarif WHERE grille_tarif.type = @type", conn)) { 

                        cmd.Parameters.AddWithValue("@type", TypeSelect.Text);
                        MySqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            idTarif = Convert.ToInt32(reader["id_tarif"]);
                            prix = reader["montant"].ToString();
                        }
                        montant = float.Parse(prix);

                        prix = (montant*= qty).ToString().Replace(',','.');
                        reader.Close();
                    }
                   
                    using (MySqlCommand comd = new MySqlCommand("INSERT INTO `frais_forfait`(`total`, `quantite`, `date`, `id_fiche`, `id_tarif`) VALUES " +
                        "(@total,@quantite,@date, @idFiche,@idTarif );", conn))
                    {
                        comd.Parameters.AddWithValue("@total", prix);
                        comd.Parameters.AddWithValue("@quantite", qty);
                        comd.Parameters.AddWithValue("@nom", TypeSelect.Text);
                        comd.Parameters.AddWithValue("@date", db.ConvertDateFormat(Calendar.Value));
                        comd.Parameters.AddWithValue("@idFiche", idFiche);
                        comd.Parameters.AddWithValue("@idTarif", idTarif);
                        comd.ExecuteNonQuery();
                        MessageBox.Show("Un nouvel élément a bien été ajouté");
                    }
                    conn.Close();
                    db.UpdateData(idFiche);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Il y a eu un problème avec la base de donnée, veuillez recommencez");
                }
            }
        }

        private int GetIdFiche()
        {
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
        private void Quantite_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (this.QuantiteInput.Value > 70 || !Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
    }
}
