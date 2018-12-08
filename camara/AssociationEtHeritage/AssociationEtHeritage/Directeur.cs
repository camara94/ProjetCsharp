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

        protected string specialite;

        public string SPECIALITE
        {
            get { return specialite; }
            set { specialite = value; }
        }
        public Service service;
        public Service SERVICE
        {
            get { return this.service; }
            set { this.service = value; }
        }
        public Directeur() : base()
        {
            this.anciennete = 0;
            this.specialite = "";
        }
        public Directeur(string mat,string nom,string grade,int anciennete,string specialite) : base(mat, nom, grade)
        {
            this.anciennete = anciennete;
            this.specialite = specialite;
        }
        
        
        public override void afficher()
        {
            Console.WriteLine("=== Directeur ===\n");
            Console.WriteLine("  Nom : {0}, Matricule : {1}, Grade : {2},Anciennété : {3} ans, Spécialité : {4}", this.nom, this.matricule, this.grade,this.anciennete,this.specialite);
            Console.WriteLine("Il dirige le service :");
            service.afficher();
        }
    }
}
