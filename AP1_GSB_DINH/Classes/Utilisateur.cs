using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP1_GSB_DINH
{
    public class Utilisateur
    {
        private int id;
        private string nom;
        private string identifiant;
        private string mdp;

        public Utilisateur(int id, string nom, string identifiant, string mdp)
        {
            this.id = id;
            this.nom = nom;
            this.identifiant = identifiant;
            this.mdp = mdp;
        }
        public int Id {
            get { return id; }
        }

        public string Nom
        {
            get { return nom; }
        }

        public string Identifiant { 
            get { return identifiant; } 
        }

        public string Mdp
        {
            get { return mdp; }
        }

    }

}
 

 
