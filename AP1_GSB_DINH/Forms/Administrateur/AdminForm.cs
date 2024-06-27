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

namespace AP1_GSB_DINH.Forms.Administrateur
{
    public partial class AdminForm : Form
    {
        string nom;
        string identifiant;
        string mdp;
        Service db= new Service();
        int idUser = 0;
        public AdminForm(int IdUser)
        {
            InitializeComponent();
            idUser = IdUser;
        }

        private void Deconnexion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void LoadForm(object Form)
        {
            if (this.mainPanel.Controls.Count > 0)
                this.mainPanel.Controls.RemoveAt(0);

            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(f);
            this.mainPanel.Tag = f;
            f.Show();
        }
        private void GestionFrais_Click(object sender, EventArgs e)
        {
            LoadForm(new GestionFrais());
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            DateLabel.Text = today.ToString("dd/MM/yyyy");
            using (MySqlConnection conn = db.GetConnection())
            {
                if (conn != null)
                {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT nom,identifiant,mot_de_passe FROM `utilisateur` WHERE utilisateur.id_utilisateur = @idUser;", conn))
                    {
                        cmd.Parameters.AddWithValue("@idUser", idUser);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                nom = reader["nom"].ToString();
                                identifiant = reader["identifiant"].ToString();
                                mdp = reader["mot_de_passe"].ToString();
                            }
                            Utilisateur newUser = new Utilisateur(idUser, nom, identifiant, mdp);

                            UserLabel.Text = newUser.Nom;

                        }
                    }
                }
            }
        }

        private void GestionUtilisateur_Click(object sender, EventArgs e)
        {
            LoadForm(new GestionUtilisateur());
        }
    }
}
