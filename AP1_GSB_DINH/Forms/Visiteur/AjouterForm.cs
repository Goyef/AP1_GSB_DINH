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

namespace AP1_GSB_DINH
{
    public partial class AjouterForm : Form
    {
        int idUser = 0;
        private Service db = new Service();
        public AjouterForm(int IdUSer)
        {
            idUser = IdUSer;
            InitializeComponent();
        }

        private void AjouterForm_Load(object sender, EventArgs e)
        {
            ShowData();

        }


        private void ShowData()
        {
            string datemy = db.DateFiche();
            using (MySqlConnection conn = db.GetConnection())
            {
                if (conn != null)
                {

                    using (MySqlCommand cmd = new MySqlCommand("SELECT ff.date, gt.type, ff.quantite, ff.total FROM fiche_frais f LEFT JOIN frais_forfait ff ON f.id_fiche = ff.id_fiche LEFT JOIN" +
                        " grille_tarif gt ON ff.id_tarif = gt.id_tarif LEFT JOIN utilisateur ON utilisateur.id_utilisateur = f.id_utilisateur WHERE f.id_utilisateur = @idUser AND f.annee_mois = @datemy", conn))
                    {
                        cmd.Parameters.AddWithValue("@idUser", idUser);
                        cmd.Parameters.AddWithValue("@datemy", datemy);
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable table = new DataTable();
                            adapter.Fill(table);
                            // Les données sélectionnées vont donc être affichées dans le Grid
                            dataGridView1.DataSource = table;
                        }


                    }
                    using (MySqlCommand command = new MySqlCommand("SELECT hf.date, hf.nom, hf.montant FROM fiche_frais f LEFT JOIN frais_hors_forfait hf ON f.id_fiche = hf.id_fiche"
                                + " LEFT JOIN utilisateur ON utilisateur.id_utilisateur = f.id_utilisateur WHERE f.id_utilisateur = @idUser AND f.annee_mois = @datemy", conn))
                    {
                        command.Parameters.AddWithValue("@IdUser", idUser);
                        command.Parameters.AddWithValue("@datemy", datemy);
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable table = new DataTable();
                            adapter.Fill(table);
                            dataGridView2.DataSource = table;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Il y a eu un probleme avec la base de donnée, veuillez recommencez");
                }
            }
        }


        private void RedirectionHorsF(object sender, EventArgs e)
        {
            AjoutHorsForfait newForm = new AjoutHorsForfait(idUser);
            this.Hide();
            if (this.ParentForm != null)
                this.ParentForm.Hide();
            newForm.ShowDialog();
            this.ParentForm.Show();
            this.Show();
            ShowData();
        }

        private void RedirectionF(object sender, EventArgs e)
        {
            AjouterForfait newForm = new AjouterForfait(idUser);
            this.Hide();
            if (this.ParentForm != null)
            {
                this.ParentForm.Hide();
            }
            newForm.ShowDialog();
            this.ParentForm.Show();
            this.Show();
            ShowData();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "total")
            {
                {
                      string value = e.Value.ToString();
                      value = value + " €";

                       e.Value  = value;
                }
            }
        }

        private void dataGridView2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView2.Columns[e.ColumnIndex].Name == "montant")
            {
                {
                    string value = e.Value.ToString();
                    value = (value + " €");

                    e.Value = value;
                }
            }
        }
    }
}
