using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP1_GSB_DINH
{
    public class Ajout
    {
        private string date;
        private string montant;
        private string nom;
        private int? quantite;

        public Ajout(string Nom, string Montant, string Date)
        {
            date = Date;
            montant = Montant;
            nom = Nom;
        }

        public string Date
        { 
            get { return date; } 
        }

        public string Montant
        { get { return montant; } }

        public string Nom
        { get { return nom; } }
        

        public int? Quantite 
        {
            get { return quantite; } 
            set { quantite = value; }
        }

    }
}
