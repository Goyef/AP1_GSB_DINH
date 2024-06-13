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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace AP1_GSB_DINH
{
    public partial class AjouterForfait : Form
    {
        int idUser = 0;
        private Service db = new Service();
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
                    using (MySqlCommand cmd = new MySqlCommand("SELECT type FROM `grille_tarif`;", conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Columns.Add("type", typeof(string));
                            dt.Load(reader);
                            TypeSelect.ValueMember = "type";
                            TypeSelect.DataSource = dt;
                            conn.Close();
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Il y a eu un probleme avec la base de donnée, veuillez recommencez");
                }
            }

        }

        private void AjoutBt_Click(object sender, EventArgs e)
        {
            
        }
    }
    
}
