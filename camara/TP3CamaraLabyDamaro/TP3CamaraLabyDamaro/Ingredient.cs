using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3CamaraLabyDamaro
{
    class Ingredient
    {
        private String nom;
        private String quantite;
        private double poids;

        public Ingredient()
        {
            this.nom = "";
            this.quantite = "";
            this.poids = 0;
        }


        public Ingredient(String nom,String quantite,double pp)
        {
            this.nom = nom;
            this.quantite =quantite;
            if (pp >= 0)
                poids = pp;
            else
                poids = 0;
        }

        public String NOM
        {
            get { return this.nom; }
            set { this.nom = value; }
        }

        public String QUANTITE
        {
            get { return this.quantite; }
            set { this.quantite = value; }
        }

        public double POIDS
        {
            get { return this.poids; }
            set { 
                    if (value >= 0)
                        poids = value;
                    else
                        poids = 0; 
            }
        }

        public void afficher()
        {
            Console.WriteLine("#{0}, {1}, {2}", this.nom, this.quantite,this.poids);
        }
    }
}
