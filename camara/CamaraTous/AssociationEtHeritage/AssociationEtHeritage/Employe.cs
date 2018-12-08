using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationEtHeritage
{
    class Employe
    {
        
        protected string matricule;

        public string MATRICULE
        {
            get { return matricule; }
            set { matricule = value; }
        }
        private Service service;

        public Service SERVICE
        {
            get { return service; }
            set { service = value; }
        }
        protected string nom;

        public string NOM
        {
            get { return nom; }
            set { nom = value; }
        }

        protected string grade;

        public string GRADE
        {
            get { return grade; }
            set { grade = value; }
        }
        
        public Employe(string mat,string nom,string grade, Service service)
        {
            this.matricule = mat;
            this.grade = grade;
            this.nom = nom;
            this.service = service;
        }

        public Employe()
        {
            this.matricule = "";
            this.grade = "";
            this.nom = "";
        }

        
        

        public virtual void afficher()
        {
           
            Console.WriteLine("================================================================================\n");
            Console.WriteLine("  Nom : {0}, Matricule : {1}, Grade : {2}",this.nom,this.matricule,this.grade);
            service.afficher();
            Console.WriteLine();
        }
    }
}
