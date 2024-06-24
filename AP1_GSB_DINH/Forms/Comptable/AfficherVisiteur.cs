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

namespace AP1_GSB_DINH.Forms
{
    public partial class AfficherVisiteur : Form
    {
        Service db = new Service();
        public AfficherVisiteur()
        {
            InitializeComponent();
        }

        private void AfficherVisiteur_Load(object sender, EventArgs e)
        {
            string datemy = db.DateFiche();
            using (MySqlConnection conn = db.GetConnection())
            {
                if (conn != null)
                {
                    using (MySqlCommand commd = new MySqlCommand("UPDATE `fiche_frais` SET `id_etat`= 1 WHERE id_etat = 2 AND fiche_frais.annee_mois != @datemy;", conn))
                    {
                        commd.Parameters.AddWithValue("@datemy", datemy);
                        commd.ExecuteNonQuery();
                    }
                    using (MySqlCommand cmd = new MySqlCommand("SELECT nom FROM `utilisateur` WHERE utilisateur.id_role = 1 ;", conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Columns.Add("nom", typeof(string));
                            dt.Load(reader);
                            UserSelect.ValueMember = "nom";
                            UserSelect.DataSource = dt;
                        }
                        DataGridViewButtonColumn acceptColumn = new DataGridViewButtonColumn();
                        acceptColumn.HeaderText = "A";
                        acceptColumn.Text = "ACCEPTER";
                        acceptColumn.UseColumnTextForButtonValue = true; // Set to true to use Text property for the button
                        dataGridView1.Columns.Add(acceptColumn);
                        DataGridViewButtonColumn refuseColum = new DataGridViewButtonColumn();
                        refuseColum.HeaderText = "R";
                        refuseColum.Text = "REFUSER";
                        refuseColum.UseColumnTextForButtonValue = true; // Set to true to use Text property for the button
                        dataGridView1.Columns.Add(refuseColum);
                    }
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Il y a eu un probleme avec la base de donnée, veuillez recommencez");
                }
            }
        }

        private void UserSelect_TextChanged(object sender, EventArgs e)
        {
            ShowData();
        }

        private void UpdateEtat(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "A")
                {
                    string idFiche = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                    using (MySqlConnection conn = db.GetConnection())
                    {
                        if (conn != null)
                        {
                            using (MySqlCommand cmd = new MySqlCommand("UPDATE `fiche_frais` SET `id_etat`= 3 WHERE fiche_frais.id_fiche = @idFiche", conn))
                            {
                                cmd.Parameters.AddWithValue("@idFiche", idFiche);
                                cmd.ExecuteNonQuery();
                                conn.Close();
                                MessageBox.Show("La fiche a bien été mise en état VALIDER");
                                ShowData();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Il y a eu un probleme avec la base de donnée, veuillez recommencez1");
                        }
                    }
                }


            }

            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "R")
            {
                string idFiche = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                using (MySqlConnection conn = db.GetConnection())
                {
                    if (conn != null)
                    {
                        using (MySqlCommand cmd = new MySqlCommand("UPDATE `fiche_frais` SET `id_etat`= 4 WHERE fiche_frais.id_fiche = @idFiche", conn))
                        {
                            cmd.Parameters.AddWithValue("@idFiche", idFiche);
                            cmd.ExecuteNonQuery();
                            conn.Close();
                            MessageBox.Show("La fiche a bien été mise en état REFUSER");
                            ShowData();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Il y a eu un probleme avec la base de donnée, veuillez recommencez2");
                    }
                }
            }

        }

        private void ShowData()
        {
            using (MySqlConnection conn = db.GetConnection())
            {
                if (conn != null)
                {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT id_fiche, annee_mois, montant,etat_fiche.etat, utilisateur.nom FROM `fiche_frais` LEFT JOIN `etat_fiche` ON etat_fiche.id_etat = fiche_frais.id_etat" +
                        " LEFT JOIN utilisateur ON utilisateur.id_utilisateur = fiche_frais.id_utilisateur WHERE fiche_frais.id_etat != 2 AND utilisateur.nom = @nom;", conn))
                    {
                        cmd.Parameters.AddWithValue("@nom", UserSelect.Text);
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
        private void DeatilClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int rowIndex = dataGridView1.SelectedRows[0].Index;

                int id = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["id_fiche"].Value);
                string dateC = dataGridView1.Rows[rowIndex].Cells["annee_mois"].Value.ToString();
                FicheForm newForm = new FicheForm(0,id,dateC);
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

        private void CurrencyFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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
    }
}