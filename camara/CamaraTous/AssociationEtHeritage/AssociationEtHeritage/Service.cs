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

        public Service(int numero,string libelle)
        {
            this.numero = numero;
            this.libelle = libelle;
        }
        

        public void afficher()
        {
            Console.WriteLine("  Le numéro du service est : "+ this.numero+ ", Libellé  du service est : " + this.libelle);
           
        }
    }
}
