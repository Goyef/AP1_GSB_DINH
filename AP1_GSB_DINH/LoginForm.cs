﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace AP1_GSB_DINH
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private DataBase db = new DataBase();

        private void Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void Login(object sender, EventArgs e)
        {
            string identifiant = textUsername.Text.Trim();
            string mdp = textPassword.Text.Trim();

            using (MySqlConnection conn = db.GetConnection())
            {
                if (conn != null)
                {
                    MySqlCommand cmd = new MySqlCommand("SELECT utilisateur.id_utilisateur FROM `utilisateur` WHERE mot_de_passe = '"+mdp+"' AND identifiant = '"+identifiant+"';", conn);
                    conn.Open();
                    int dataId = Convert.ToInt32(cmd.ExecuteScalar());
                    if (dataId == 0)
                    {
                        MessageBox.Show("L'identifiant ou le mot de passe n'est pas bon, veuillez recommencez");
                        textUsername.Clear();
                        textPassword.Clear();
                        textUsername.Focus();
                        return;
                    }
                    MySqlCommand command = new MySqlCommand("SELECT role FROM `role` INNER JOIN utilisateur ON utilisateur.id_role = role.id_role WHERE utilisateur.id_utilisateur = "+dataId+";", conn);
                    string role = Convert.ToString(command.ExecuteScalar());
                    conn.Close();

                    Redirection(role, dataId);
                    }
                    else
                        {
                        MessageBox.Show("Il y a eu un probleme avec la base de donnée, veuillez recommencez");
                        }
                    }
                    
                }
        private void Redirection(string role, int dataId)
        {
            switch (role)
            {
                case "visiteur":
                    pageVisiteur newForm = new pageVisiteur(dataId);
                    this.Hide();
                    newForm.ShowDialog();
                    break;
                case "comptable":

                    break;
            }
        }
    }
    
  }
