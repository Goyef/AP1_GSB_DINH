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

        public List<string> DataLimite()
        {
            List<string> list = new List<string>();

            //SELECT* FROM `frais_hors_forfait` WHERE frais_hors_forfait.date >= "11-06-2024" AND frais_hors_forfait.date <= "10-07-2024"

            DateTime now = DateTime.Now;
            MessageBox.Show(now.ToString());

            if (now.Day < 11)
            {
                now = now.AddMonths(-1);
            }
            string dateMin = $"11-{now.Month}-2024";
            list.Add(dateMin);
            now = now.AddMonths(1);
            string dateMax = $"10-{now.Month}-2024";
            list.Add(dateMax);
            return list;
        }
    }
}
