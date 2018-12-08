using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationEtHeritage
{
    class Service
    {
        private int numero;

        public int NUMERO
        {
            get { return numero; }
            set { numero = value; }
        }

        private string libelle;

        public string LIBELLE
        {
            get { return libelle; }
            set { libelle = value; }
        }


        public List<Employe> listEmployer = new List<Employe>();
        public Directeur directeur = new Directeur();

        public Service(int numero,string libelle,List<Employe> listEmployer,Directeur directeur)
        {
            this.numero = numero;
            this.libelle = libelle;
            this.listEmployer = listEmployer;
            this.directeur = directeur;
        }
        

        public void afficher()
        {
            Console.WriteLine("Le numéro de service est : {0}, Libellé est : {1}", this.numero,this.libelle);
            Console.WriteLine();
           /* this.directeur.afficher();
            foreach(Employe employe in this.listEmployer)
            {
                employe.afficher();
            }*/
           
        }
    }
}
