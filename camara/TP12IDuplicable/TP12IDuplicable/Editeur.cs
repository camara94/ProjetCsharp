using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP12IDuplicable
{
   public class Editeur
    {
        protected string adr;

        public string ADR
        {
            get { return adr; }
            set { adr = value; }
        }

        private string nom;

        public string NOM
        {
            get { return nom; }
            set { nom = value; }
        }

        public Editeur(string nom,string adr)
        {
            this.nom = nom;
            this.adr = adr;
        }
        
    }
}
