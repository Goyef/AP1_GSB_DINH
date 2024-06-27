using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace AP1_GSB_DINH
{
    public partial class FicheForm : Form
    {
        int idUser;
        static private Service db = new Service();
        string datemy = db.DateFiche();
        int idFiche = 0;

        int idFicheC;
        string dateFicheC;
        public FicheForm(int IdUser = 99, int IdFicheC = 0, string DateFicheC = "")
        {
            idUser = IdUser;
            idFicheC = IdFicheC;
            dateFicheC = DateFicheC;
            InitializeComponent();
        }
    

        private void FicheForm_Load(object sender, EventArgs e)
        {
            
            if (idFicheC == 0)
            {
                string[] listDate = datemy.Split('-');
                DateConverter(listDate);
                GetIdFiche();
            }
            else
            {
                ExitBt.Visible = true;
                ExitBt.Enabled = true;
                idFiche = idFicheC;
                string[] listDate = dateFicheC.Split('-');
                DateConverter(listDate);
                
            }
            using (MySqlConnection conn = db.GetConnection())
            {
                if (conn != null)
                {

                    using (MySqlCommand cmd = new MySqlCommand("SELECT ff.date, gt.type, ff.quantite, ff.total FROM fiche_frais f LEFT JOIN frais_forfait ff ON f.id_fiche = ff.id_fiche LEFT JOIN" +
                        " grille_tarif gt ON ff.id_tarif = gt.id_tarif WHERE f.id_fiche = @idFiche", conn))
                    {
                        cmd.Parameters.AddWithValue("@idFiche", idFiche);
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable table = new DataTable();
                            adapter.Fill(table);
                            // Les données sélectionnées vont donc être affichées dans le Grid
                            dataGridView1.DataSource = table;
                        }

                    }
                    using (MySqlCommand command = new MySqlCommand("SELECT hf.date, hf.nom, hf.montant FROM fiche_frais f LEFT JOIN frais_hors_forfait hf ON f.id_fiche = hf.id_fiche"
                                + " WHERE f.id_fiche = @idFiche", conn))
                    {
                        command.Parameters.AddWithValue("@idFiche", idFiche);
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable table = new DataTable();
                            adapter.Fill(table);
                            dataGridView2.DataSource = table;
                        }
                    }
                    db.UpdateData(idFiche);
                    using (MySqlCommand comd = new MySqlCommand("SELECT montant FROM `fiche_frais` WHERE fiche_frais.id_fiche = @idFiche", conn))
                    {
                        comd.Parameters.AddWithValue("@idFiche", idFiche);
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(comd))
                        {
                            DataTable table = new DataTable();
                            adapter.Fill(table);
                            dataGridView3.DataSource = table;
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
            if (dataGridView1.Columns[e.ColumnIndex].Name == "total")
            {
                {
                    string value = e.Value.ToString() + " €";

                    e.Value = value;
                }
            }
        }

        private void dataGridView2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView2.Columns[e.ColumnIndex].Name == "montant")
            {
                {
                    string value = e.Value.ToString() + " €";

                    e.Value = value;
                }
            }
        }

        private void dataGridView3_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView3.Columns[e.ColumnIndex].Name == "montant")
            {
                {
                    string value = e.Value.ToString() + " €";

                    e.Value = value;
                }
            }
        }
        private void DateConverter(string[] listDate)
        { 
            string year = listDate[0];
            AnneeLabel.Text = year;
            int month = Convert.ToInt32(listDate[1]);
            MoisLabel.Text = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(month);
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

        private void ExitBt_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
