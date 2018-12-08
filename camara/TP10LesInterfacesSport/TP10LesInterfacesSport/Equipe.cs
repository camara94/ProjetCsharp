using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP10LesInterfacesSport
{
    public class Equipe
    {
        private String nomEq;

        public String NOMEQ
        {
            get { return nomEq; }
            set { nomEq = value; }
        }

        private int nbrJoueur;

        public int NBRJOUEUR
        {
            get { return nbrJoueur; }
            set { nbrJoueur = value; }
        }

        public Equipe(string nom,int nbreJ)
        {
            this.nomEq = nom;
            this.nbrJoueur = nbreJ;
        }
        public void afficher()
        {
            Console.WriteLine("Nom équipe :{0} et est composée de {1} joueurs", this.nomEq, this.nbrJoueur);
        }
    }
}
