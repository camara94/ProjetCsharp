using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP9InterfaceClassAbstraiteEtHeritage
{
    class Locomotive:Wagon
    {
         private string energie;

        public string ENERGIE
        {
            get { return energie; }
            set { energie = value; }
        }

        private int puissance;

        public int CHARGEMAX
        {
            get { return puissance; }
            set { puissance = value; }
        }
        
        public Locomotive(string matricule,string energie,int puissance) : base(matricule)
        {
            this.energie = energie;
            this.puissance = puissance;
        }

        
        public override void afficher()
        {
            Console.WriteLine("Matricule : {0}\nEnergie : {1}\nPuissance : {2}", this.matricule, this.energie, this.puissance);
        }
    }
}
