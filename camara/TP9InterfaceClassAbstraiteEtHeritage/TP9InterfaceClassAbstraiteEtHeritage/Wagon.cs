using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP9InterfaceClassAbstraiteEtHeritage
{
    public abstract class Wagon
    {
        protected string matricule;

        public string MATRICULE
        {
            get { return matricule; }
            set { matricule = value; }
        }

        public Wagon(string matricule)
        {
            this.matricule = matricule;
        }
        public abstract void afficher();
        
    }
}
