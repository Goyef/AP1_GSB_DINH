using Google.Protobuf.WellKnownTypes;
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
    public partial class ModalGestionUtilisateur : Form
    {
        string fonction;
        int idRole = 0;
        Service db = new Service();
        public ModalGestionUtilisateur(string Fonction)
        {
            InitializeComponent();
            fonction = Fonction;
        }

        private void ExitBt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModalGestionUtilisateur_Load(object sender, EventArgs e)
        {
            using (MySqlConnection conn = db.GetConnection())
            {
                if (conn != null)
                {
                    if (fonction == "A")
                    {
                        ModAJout.Text = "Ajouter";
                    }
                    else if (fonction == "M")
                    {
                        IdLabel.Visible = true;
                        IdLabel.Enabled = true;
                        UserSelect.Visible = true;
                        UserSelect.Enabled = true;
                        ModAJout.Text = "Modifier";
                    }
                    using (MySqlCommand cmd = new MySqlCommand("SELECT id_utilisateur FROM `utilisateur`;", conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Columns.Add("id_utilisateur", typeof(string));
                            dt.Load(reader);
                            UserSelect.ValueMember = "id_utilisateur";
                            UserSelect.DataSource = dt;
                        }
                    }
                    using (MySqlCommand cmd = new MySqlCommand("SELECT role FROM `role`;", conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Columns.Add("role", typeof(string));
                            dt.Load(reader);
                            RoleSelect.ValueMember = "role";
                            RoleSelect.DataSource = dt;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Il y a eu un problème avec la base de donnée, veuillez recommencez");
                }
            }
        }

        private void Validate_Click(object sender, EventArgs e)
        {
            if (fonction == "A")
                AddUser();
            else if (fonction == "M")
                EditUser();
        }

        private void EditUser()
        {
            if (IdentifiantInput.Text == "")
            {
                MessageBox.Show("Veuillez saisir un identifiant");
                return;
            }
            if (mdpInput.Text == "")
            {
                MessageBox.Show("Veuillez saisir un mot de passe");
                return;
            }
            if (NomInput.Text == "")
            {
                MessageBox.Show("Veuillez saisir un nom");
                return;
            }
            using (MySqlConnection conn = db.GetConnection())
            {
                if (conn != null)
                {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT id_role FROM role WHERE role.role = @role", conn))
                    {
                        cmd.Parameters.AddWithValue("@role", RoleSelect.Text);
                        idRole = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                    using (MySqlCommand command = new MySqlCommand("UPDATE `utilisateur` SET `nom`=@nom,`identifiant`=@identifiant,`mot_de_passe`=@mdp,`id_role`=@id_role WHERE utilisateur.id_utilisateur = @idUser;", conn))
                    {
                        command.Parameters.AddWithValue("@idUser", UserSelect.Text);
                        command.Parameters.AddWithValue("@id_role", idRole);
                        command.Parameters.AddWithValue("@mdp", mdpInput.Text);
                        command.Parameters.AddWithValue("@identifiant", IdentifiantInput.Text);
                        command.Parameters.AddWithValue("@nom", NomInput.Text);
                        command.ExecuteNonQuery();
                        MessageBox.Show($"L'utilsateur {UserSelect.Text} a bien eu ses données modifiées");
                    }
                    conn.Close();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Il y a eu un problème avec la base de donnée, veuillez recommencez");
                }
            }
        }
        private void AddUser()
        {
            if (IdentifiantInput.Text == "")
            {
                MessageBox.Show("Veuillez saisir un identifiant");
                return;
            }
            if (mdpInput.Text == "")
            {
                MessageBox.Show("Veuillez saisir un mot de passe");
                return;
            }
            if (NomInput.Text == "")
            {
                MessageBox.Show("Veuillez saisir un nom");
                return;
            }
            using (MySqlConnection conn = db.GetConnection())
            {
                if (conn != null)
                {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT id_role FROM role WHERE role.role = @role", conn))
                    {
                        cmd.Parameters.AddWithValue("@role", RoleSelect.Text);
                        idRole = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                    using (MySqlCommand comd = new MySqlCommand("INSERT INTO `utilisateur`(`nom`, `identifiant`,`mot_de_passe`,`id_role`) VALUES " +
                        "(@nom, @identifiant,@mot_de_passe,@id_role);", conn))
                    {
                        comd.Parameters.AddWithValue("@nom", NomInput.Text);
                        comd.Parameters.AddWithValue("@identifiant", IdentifiantInput.Text);
                        comd.Parameters.AddWithValue("@mot_de_passe", mdpInput.Text);
                        comd.Parameters.AddWithValue("@id_role", idRole);
                        comd.ExecuteNonQuery();
                        MessageBox.Show("Un nouvel élément a bien été ajouté");
                    }
                    conn.Close();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Il y a eu un problème avec la base de donnée, veuillez recommencez");
                }
            }
        }
        private void UserSelect_TextChanged(object sender, EventArgs e)
        {
            if (UserSelect.Visible)
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT nom, identifiant, mot_de_passe FROM utilisateur WHERE utilisateur.id_utilisateur = @idUser", conn))
                    {
                        cmd.Parameters.AddWithValue("@idUser", UserSelect.Text);
                        MySqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            NomInput.Text = reader["nom"].ToString();
                            IdentifiantInput.Text = reader["identifiant"].ToString();
                            mdpInput.Text = reader["mot_de_passe"].ToString();
                        }
                        reader.Close();
                    }
                    using (MySqlCommand command = new MySqlCommand("SELECT role FROM role RIGHT JOIN utilisateur ON utilisateur.id_role = role.id_role WHERE utilisateur.id_utilisateur = @idUser", conn))
                    {
                        command.Parameters.AddWithValue("@idUser", UserSelect.Text);
                        RoleSelect.Text = command.ExecuteScalar().ToString();
                    }
                }

            }
        }
    }
}
