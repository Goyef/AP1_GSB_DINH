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
    public partial class GestionFrais : Form
    {
        string fonction;
        private Service db = new Service();
        public GestionFrais()
        {
            InitializeComponent();
        }

        private void GestionFrais_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        private void ShowData()
        {
            using (MySqlConnection conn = db.GetConnection())
            {
                if (conn != null)
                {
                    using (MySqlCommand command = new MySqlCommand("SELECT * FROM `grille_tarif` ", conn))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable table = new DataTable();
                            adapter.Fill(table);
                            dataGridView1.DataSource = table;
                        }
                    }
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Il y a eu un problème avec la base de donnée, veuillez recommencez");
                }
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

        private void AjouterBt_Click(object sender, EventArgs e)
        {
           fonction = "A";
            ModalGestionFrais newForm = new ModalGestionFrais(fonction);
            this.Hide();
            if (this.ParentForm != null)
                this.ParentForm.Hide();
            newForm.ShowDialog();
            this.ParentForm.Show();
            this.Show();
            ShowData();
        }

        private void ModifierBt_Click(object sender, EventArgs e)
        {
            fonction = "M";
            ModalGestionFrais newForm = new ModalGestionFrais(fonction);
            this.Hide();
            if (this.ParentForm != null)
                this.ParentForm.Hide();
            newForm.ShowDialog();
            this.ParentForm.Show();
            this.Show();
            ShowData();
        }
    }
}
