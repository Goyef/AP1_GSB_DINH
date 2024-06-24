using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP1_GSB_DINH
{
    public class Service
    {
        private string ConnectionString = "server=127.0.0.1;uid=root;pwd=root;database=gsb_dinh";

        public MySqlConnection GetConnection()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(ConnectionString);
                connection.Open();
                return connection;
            }
            catch 
            {
                return null;
            }
        }
        public string ConvertDateFormat(DateTime date)
        {
            string day = date.Day.ToString();
            string month = date.Month.ToString();
            string year = date.Year.ToString();
            string returnValue = $"{year}-{month}-{day}" ;
            return returnValue;
        } 
        

        public string DateFiche()
        {
            DateTime now = DateTime.Now;
            if (now.Day < 11)
            {
                now = now.AddMonths(-1);
            }

            string returnDate = $"{now.Year}-{now.Month}";
            return returnDate;
        }

        public void UpdateData(int idFiche)
        {
            using (MySqlConnection conn = GetConnection())
            {
                if (conn != null)
                {
                    using (MySqlCommand cmd3 = new MySqlCommand("SELECT * FROM fiche_frais RIGHT JOIN frais_hors_forfait ON frais_hors_forfait.id_fiche = fiche_frais.id_fiche " +
                        "RIGHT JOIN frais_forfait ON frais_forfait.id_fiche = fiche_frais.id_fiche WHERE fiche_frais.id_fiche = @idFiche", conn))
                    {
                        cmd3.Parameters.AddWithValue("@idFiche", idFiche);
                        if (Convert.ToInt32(cmd3.ExecuteScalar()) != 0)
                        {
                            using (MySqlCommand command = new MySqlCommand("UPDATE fiche_frais SET fiche_frais.montant = ( SELECT SUM(frais_forfait.total) FROM frais_forfait WHERE" +
                 " frais_forfait.id_fiche = fiche_frais.id_fiche ) + ( SELECT SUM(frais_hors_forfait.montant) FROM frais_hors_forfait WHERE frais_hors_forfait.id_fiche =" +
                 " fiche_frais.id_fiche ) WHERE fiche_frais.id_fiche = @idFiche;", conn))
                            {
                                command.Parameters.AddWithValue("@idFiche", idFiche);
                                command.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            using (MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM frais_forfait WHERE frais_forfait.id_fiche = @idFiche", conn))
                            {
                                cmd1.Parameters.AddWithValue("@idFiche", idFiche);
                                if (Convert.ToInt32(cmd1.ExecuteScalar()) != 0)
                                {
                                    using (MySqlCommand command = new MySqlCommand("UPDATE fiche_frais SET fiche_frais.montant = ( SELECT SUM(frais_forfait.total) FROM frais_forfait WHERE" +
                               " frais_forfait.id_fiche = fiche_frais.id_fiche ) WHERE fiche_frais.id_fiche = @idFiche;", conn))
                                    {
                                        command.Parameters.AddWithValue("@idFiche", idFiche);
                                        command.ExecuteNonQuery();
                                    }
                                }
                            }
                            using (MySqlCommand cmd2 = new MySqlCommand("SELECT * FROM frais_hors_forfait WHERE frais_hors_forfait.id_fiche = @idFiche", conn))
                            {
                                cmd2.Parameters.AddWithValue("@idFiche", idFiche);
                                if (Convert.ToInt32(cmd2.ExecuteScalar()) != 0)
                                {
                                    using (MySqlCommand command = new MySqlCommand("UPDATE fiche_frais SET fiche_frais.montant = ( SELECT SUM(frais_hors_forfait.montant) FROM frais_hors_forfait WHERE" +
                                    " frais_hors_forfait.id_fiche = fiche_frais.id_fiche ) WHERE fiche_frais.id_fiche = @idFiche;", conn))
                                    {
                                        command.Parameters.AddWithValue("@idFiche", idFiche);
                                        command.ExecuteNonQuery();
                                    }
                                }
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
    }
}
