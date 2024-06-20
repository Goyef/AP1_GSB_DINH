﻿using MySql.Data.MySqlClient;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace AP1_GSB_DINH
{
    public partial class AjouterForfait : Form
    {
        int idUser = 0;
        int idFiche = 0;
        private Service db = new Service();
        int idTarif;
        public AjouterForfait(int IdUser)
        {
            idUser = IdUser;
            InitializeComponent();
        }



        private void returnBt_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void FixlimitDate()
        {
            DateTime now = DateTime.Now;
            string min;
            if (now.Day < 11)
            {
                now = now.AddMonths(-1);
            }

            min = $"11 {now.Month} {now.Year}";
            DateTime Min = DateTime.Parse(min);
            DateTime Max = Min.AddMonths(1);
            Max = Max.AddDays(-1);

            Calendar.MinDate = Min;
            Calendar.MaxDate = Max;
        }


        private void AjouterForfait_Load(object sender, EventArgs e)
        {
            FixlimitDate();
            using (MySqlConnection conn = db.GetConnection())
            {
                if (conn != null)
                {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM `grille_tarif`;", conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Columns.Add("type", typeof(string));
                            dt.Load(reader);
                            TypeSelect.ValueMember = "type";
                            TypeSelect.DataSource = dt;
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

        private void AjoutBt_Click(object sender, EventArgs e)
        {
            
            string prix ="";
            float montant;
            int qty = Convert.ToInt32(numericUpDown1.Value);

            string datemy = db.DateFiche();

            using (MySqlConnection conn = db.GetConnection())
            {
                if (conn != null)
                {
                    using (MySqlCommand command = new MySqlCommand("SELECT id_fiche FROM fiche_frais LEFT JOIN utilisateur On utilisateur.id_utilisateur = fiche_frais.id_utilisateur " +
                      "WHERE fiche_frais.id_utilisateur = @idUser AND fiche_frais.annee_mois = @datemy", conn))
                    {
                        command.Parameters.AddWithValue("@idUser", idUser);
                        command.Parameters.AddWithValue("datemy", datemy);
                        idFiche = Convert.ToInt32(command.ExecuteScalar());

                        MySqlCommand cmd = new MySqlCommand("SELECT frais_forfait.id_tarif, grille_tarif.montant FROM frais_forfait LEFT JOIN grille_tarif ON " +
                            "grille_tarif.id_tarif = frais_forfait.id_tarif WHERE grille_tarif.type = @type", conn);
                        cmd.Parameters.AddWithValue("@type", TypeSelect.Text);
                        MySqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            idTarif = Convert.ToInt32(reader["id_tarif"]);
                            prix = reader["montant"].ToString();
                        }
                        montant = float.Parse(prix);

                        prix = (montant*= qty).ToString().Replace(',','.');
                        reader.Close();
                    }
                   
                    using (MySqlCommand comd = new MySqlCommand("INSERT INTO `frais_forfait`(`total`, `quantite`, `date`, `id_fiche`, `id_tarif`) VALUES " +
                        "(@total,@quantite,@date, @idFiche,@idTarif );", conn))
                    {
                        comd.Parameters.AddWithValue("@total", prix);
                        comd.Parameters.AddWithValue("@quantite", qty);
                        comd.Parameters.AddWithValue("@nom", TypeSelect.Text);
                        comd.Parameters.AddWithValue("@date", db.ConvertDateFormat(Calendar.Value));
                        comd.Parameters.AddWithValue("@idFiche", idFiche);
                        comd.Parameters.AddWithValue("@idTarif", idTarif);
                        comd.ExecuteNonQuery();
                        MessageBox.Show("Un nouvel élément a bien été ajouté");
                    }
                    conn.Close();
                    UpdateData();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Il y a eu un problème avec la base de donnée, veuillez recommencez");
                }
            }
        }

        private void UpdateData()
        {
            using (MySqlConnection conn = db.GetConnection())
            {
                //mettre le update data dans le service
                if (conn != null)
                {
                    // besoin id fiche
                    using (MySqlCommand command = new MySqlCommand("UPDATE fiche_frais SET fiche_frais.montant = ( SELECT SUM(frais_forfait.total) FROM frais_forfait WHERE" +
                        " frais_forfait.id_fiche = fiche_frais.id_fiche ) + ( SELECT SUM(frais_hors_forfait.montant) FROM frais_hors_forfait WHERE frais_hors_forfait.id_fiche =" +
                        " fiche_frais.id_fiche ) WHERE fiche_frais.id_fiche = @idFiche;", conn))
                    {
                        command.Parameters.AddWithValue("@idFiche", idFiche);
                        command.ExecuteNonQuery();
                    }
                    conn.Close();

                }
                else
                {
                    MessageBox.Show("Il y a eu un probleme avec la base de donnée, veuillez recommencez");
                }
            }
        }

        private void numericUpDown1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (this.numericUpDown1.Value > 50 || !Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
    }
}