using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationEtHeritage
{
    class Directeur : Employe
    {
        protected int anciennete;

        public int ANCIENNETE
        {
            get { return anciennete; }
            set { anciennete = value; }
        }
        private Service dirige;

        protected string specialite;

        public string SPECIALITE
        {
            get { return specialite; }
            set { specialite = value; }
        }
         
        public Directeur() : base()
        {
            this.anciennete = 0;
            this.specialite = "";
        }
        public Directeur(string mat,string nom,string grade, Service service,int anciennete,string specialite) : base(mat, nom, grade,service)
        {
            this.anciennete = anciennete;
            this.specialite = specialite;
        }



        public override void afficher()
        {
            //Console.WriteLine("=== Directeur ===\n");
            base.afficher();
            Console.WriteLine("  Votre anciennété est de " + this.anciennete + " ans et votre spécialité est : " + this.specialite);
            Console.WriteLine();
        }
    }
}
