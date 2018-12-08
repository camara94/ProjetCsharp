using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP10LesInterfacesSport
{
    
    public class Sport : ISport
    {
        //private static int n = 0;
        private string categorie;
        private int nbrEquipes;
        private string nom;
        private List<Equipe> listeEquipe = new List<Equipe>();
        public string CATEGORIE
        {
            get
            {
                return this.categorie;
            }

            set
            {
                this.categorie = value;
            }
        }

        public int NBREQUIPE
        {
            get
            {
                return this.nbrEquipes;
            }
            set
            {
                this.nbrEquipes = value;
            }
        }

        public string NOM
        {
            get
            {
                return this.nom;
            }

            set
            {
                this.nom = value;
            }
        }

        public Sport(string nom,string categorie,List<Equipe> eq)
        {
            this.listeEquipe = eq;
            this.NBREQUIPE = listeEquipe.Count;
            this.nom = nom;
            this.categorie = categorie;
            //n++;

        }

        public virtual void afficherCaracteristiques()
        {
            Console.WriteLine("Nom de sport : {0}\nNombre d'équipes : {1}\nCatégorie : {2}", this.nom, this.nbrEquipes, this.categorie);
            foreach(Equipe sip in listeEquipe)
            {
                sip.afficher();
            }
        }
    }
}
