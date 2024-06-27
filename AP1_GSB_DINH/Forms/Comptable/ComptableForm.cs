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

namespace AP1_GSB_DINH.Forms
{
    public partial class ComptableForm : Form
    {
        int idUser = 0;
        private string nom;
        private string identifiant;
        private string mdp;
        private Service db = new Service();
        public ComptableForm(int IdUser)
        {
            InitializeComponent();
            idUser = IdUser;
        }

        private void Exit(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ComptableForm_Load(object sender, EventArgs e)
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

        private void ShowFiches(object sender, EventArgs e)
        {
            LoadForm(new AfficherVisiteur());
        }
    }
}
