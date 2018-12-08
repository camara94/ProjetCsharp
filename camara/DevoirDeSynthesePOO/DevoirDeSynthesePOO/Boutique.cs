using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevoirDeSynthesePOO
{
    class Boutique
    {
        private string nom;

        public string NOM
        {
            get { return nom; }
            set { nom = value; }
        }

        private string adresse;

        public string ADRESSE
        {
            get { return adresse; }
            set { adresse = value; }
        }

        private string domaineActivite;

        public string DOMAINEACTIVITE
        {
            get { return domaineActivite; }
            set { domaineActivite = value; }
        }
        

        public Boutique(string nom,string adresse,string domaineActivite)
        {
            this.nom = nom;
            this.adresse = adresse;
            this.domaineActivite = domaineActivite;
        }

        public void afficher()
        {
            Console.WriteLine("Cette boutique est caracterisée par : \nNom : {0}\nAdresse : {1}\nDomaine d'activité : {2}", this.nom, this.adresse, this.domaineActivite);
        }
    }
}
