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
    public class DataBase
    {
        private string ConnectionString = "server=127.0.0.1;uid=root;pwd=root;database=gsb_dinh";

        public MySqlConnection GetConnection()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(ConnectionString);
                return connection;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Erreur lors de la connexion à la base de données : {ex.Message}");
                return null;
            }
        }
    }
}
