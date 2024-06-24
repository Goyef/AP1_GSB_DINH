using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP1_GSB_DINH
{
    public partial class Historique : Form
    {
        int idUser = 0;
        private Service db = new Service(); 
        public Historique(int IdUser)
        {
            InitializeComponent();
            idUser = IdUser;
        }

        private void Historique_Load(object sender, EventArgs e)
        {

            string datemy = db.DateFiche();
            using (MySqlConnection conn = db.GetConnection())
            {
                if (conn != null)
                {
                    using (MySqlCommand cmd = new MySqlCommand("UPDATE `fiche_frais` SET `id_etat`= 1 WHERE id_etat = 2 AND fiche_frais.annee_mois != @datemy;" +
                        "SELECT id_fiche, annee_mois, montant,etat_fiche.etat FROM `fiche_frais` LEFT JOIN `etat_fiche` ON etat_fiche.id_etat = fiche_frais.id_etat " +
                        "WHERE fiche_frais.id_utilisateur = @idUser;", conn))
                    {
                        cmd.Parameters.AddWithValue("@idUser", idUser);
                        cmd.Parameters.AddWithValue("@datemy", datemy);
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            // Les données sélectionnées vont donc être affichées dans le Grid
                            dataGridView1.DataSource = table;
                            conn.Close();
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Il y a eu un probleme avec la base de donnée, veuillez recommencez");
                }
            }
        }
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "montant")
            {
                {
                    string value = e.Value.ToString();
                    value = value + " €";

                    e.Value = value;
                }
            }
        }

        private void DetailBt_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int rowIndex = dataGridView1.SelectedRows[0].Index;

                int id = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["id_fiche"].Value);
                string dateC = dataGridView1.Rows[rowIndex].Cells["annee_mois"].Value.ToString();
                FicheForm newForm = new FicheForm(0, id, dateC);
                this.Hide();
                if (this.ParentForm != null)
                {
                    this.ParentForm.Hide();
                }
                newForm.ShowDialog();
                this.ParentForm.Show();
                this.Show();
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une ligne.");
            }
        }
    }
}
