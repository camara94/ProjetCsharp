using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5CamaraLabyDamaro
{
    class Client
    {
        private String nom;
        private double credit;

        public Client()
        {
            this.nom = "";
            this.credit = 0;
        }

        public Client(String nom,double credit)
        {
            this.nom = nom;
            this.credit = credit;
        }

        public String NOM
        {
            get { return this.nom; }
            set { this.nom = value; }
        }

        public double CREDIT
        {
            get { return this.credit; }
            set { this.credit = value; }
        }

        public void afficher()
        {
            Console.WriteLine("Nom:{0}\nCrédit:{1}", this.nom, this.credit);
        }
    }
}
