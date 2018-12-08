using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5CamaraLabyDamaro
{
    class Medicament
    {
        private String nom;
        private double prix;
        private int stock;

        public Medicament()
        {
            this.nom = "";
            this.prix = 0;
            this.stock = 0;
        }

        public Medicament(String nom, double prix, int stock)
        {
            this.nom = nom;
            this.prix = prix;
            this.stock = stock;
        }

        public String NOM
        {
            get { return this.nom; }
            set { this.nom = value; }
        }

        public double PRIX
        {
            get { return this.prix; }
            set { this.prix = value; }
        }

        public int STOCK
        {
            get { return this.stock; }
            set { this.stock = value; }
        }

        public void afficher()
        {
            Console.WriteLine("Nom : {0}\nPrix : {1}\nStock : {2}", this.nom, this.prix,this.stock);
        }
        

    }
}
