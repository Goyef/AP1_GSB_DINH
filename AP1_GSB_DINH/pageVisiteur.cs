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
    public partial class pageVisiteur : Form
    {
        private int idUser = 0;
        private string nom;
        private string identifiant;
        private string mdp;
        private DataBase db = new DataBase();
        public pageVisiteur(int id_user)
        {
            InitializeComponent();
            idUser = id_user;
            MessageBox.Show(id_user.ToString());
        }


        private void pageVisiteur_Load(object sender, EventArgs e)
        {
            using (MySqlConnection conn = db.GetConnection())
            {
                if (conn != null)
                {
                  
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand("SELECT nom,identifiant,mot_de_passe FROM `utilisateur` WHERE utilisateur.id_utilisateur = " + idUser + ";", conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                        {
                            while (reader.Read())
                            {
                                nom = reader["nom"].ToString();
                                identifiant = reader["identifiant"].ToString();
                                mdp = reader["mot_de_passe"].ToString();
                            }
                            Utilisateur newUser = new Utilisateur(idUser, nom, identifiant, mdp);

                            label1.Text = newUser.Nom ;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Il y a eu un probleme avec la base de donnée, veuillez recommencez");
                }
             }
        }
    }
 }
        
    
