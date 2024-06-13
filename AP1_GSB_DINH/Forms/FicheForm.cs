using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace AP1_GSB_DINH
{
    public partial class FicheForm : Form
    {
        int idUser = 0;
        private Service db = new Service();

        public FicheForm(int IdUser)
        {
            idUser = IdUser;
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FicheForm_Load(object sender, EventArgs e)
        {
            string datemy = db.DateFiche();
            string[] listDate = datemy.Split('-');
            DateConverter(listDate);
            
            using (MySqlConnection conn = db.GetConnection())
            {
                if (conn != null)
                {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT nom,identifiant,mot_de_passe FROM `utilisateur` WHERE utilisateur.id_utilisateur = ;", conn))
                    {
                        conn.Close(); 
                    }
                }
                else
                {
                    MessageBox.Show("Il y a eu un probleme avec la base de donnée, veuillez recommencez");
                }
            }
        }
        private void DateConverter(string[] listDate)
        { 
            string year = listDate[0];
            AnneeLabel.Text = year;
            int month = Convert.ToInt32(listDate[1]);
            MoisLabel.Text = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(month);
        }
       
    }
}
