using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP1_GSB_DINH
{
    public partial class VisiteurForm : Form
    {
        private int idUser = 0;
        private string nom;
        private string identifiant;
        private string mdp;
        private Service db = new Service();


        public VisiteurForm(int id_user)
        {
            InitializeComponent();
            idUser = id_user;
        }


        private void pageVisiteur_Load(object sender, EventArgs e)
        {
            string datemy = db.DateFiche();
            DateTime today = DateTime.Today;
            DateLabel.Text = today.ToString("d/MM/yyyy");
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
                          
                            UserLabel.Text = newUser.Nom ;
                          
                        }
                    }
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM `fiche_frais` WHERE fiche_frais.annee_mois = @datemy AND fiche_frais.id_utilisateur = @idUser;", conn))
                    {
                        cmd.Parameters.AddWithValue("@idUser", idUser);
                        cmd.Parameters.AddWithValue("@datemy", datemy);
                        int dataId = Convert.ToInt32(cmd.ExecuteScalar());
                        if (dataId == 0)
                        {
                            using (MySqlCommand command = new MySqlCommand("INSERT INTO `fiche_frais` (`annee_mois`, `montant`, `id_etat`, `id_utilisateur`) VALUES (@datemy, 0, 2, @idUser); ", conn))
                            {
                                command.Parameters.AddWithValue("@idUser", idUser);
                                command.Parameters.AddWithValue("@datemy", datemy);
                                command.ExecuteNonQuery();
                                MessageBox.Show("Une nouvelle fiche pour ce mois a été ajouté");
                            }
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

        private void Exit(object sender, EventArgs e)
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
       
        private void button1_Click(object sender, EventArgs e)
        {
            LoadForm(new Historique(idUser));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadForm(new FicheForm(idUser));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadForm(new AjouterForm(idUser));
        }

       

        private void DateLabel_Click(object sender, EventArgs e)
        {

        }
    }

 }
        
    
