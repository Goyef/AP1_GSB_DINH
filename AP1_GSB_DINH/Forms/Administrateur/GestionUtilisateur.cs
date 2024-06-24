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

namespace AP1_GSB_DINH.Forms.Administrateur
{
    public partial class GestionUtilisateur : Form
    {
        string fonction;
        Service db = new Service();
        public GestionUtilisateur()
        {
            InitializeComponent();
        }

        private void GestionUtilisateur_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        private void ShowData()
        {
            using (MySqlConnection conn = db.GetConnection())
            {
                if (conn != null)
                {
                    using (MySqlCommand command = new MySqlCommand("SELECT id_utilisateur, nom, identifiant, mot_de_passe, role.role FROM `utilisateur` LEFT JOIN role ON role.id_role = utilisateur.id_role ", conn))
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

        private void AjouterBt_Click(object sender, EventArgs e)
        {
            fonction = "A";
            ModalGestionUtilisateur newForm = new ModalGestionUtilisateur(fonction);
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
            ModalGestionUtilisateur newForm = new ModalGestionUtilisateur(fonction);
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
