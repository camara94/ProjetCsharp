using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeritageEtPolymorphisme
{
    class CCamion:CVehicule
    {
        protected bool semi;

        public bool SEMI
        {
            get { return semi; }
            set { semi = value; }
        }

        private int nbrEssieux;

        public int NBRESSIEUX
        {
            get { return nbrEssieux; }
            set { nbrEssieux = value; }
        }


        public CCamion(int a, string im, string marq, string model, bool semi, int ess)
            : base(a, im, marq, model)
        {
            this.semi = semi;
            this.nbrEssieux = ess;
        }

        /*public void getDescription()
        {
            string essieu = (this.semi) ? " est semi camion " : "c'est camion";
            base.getDescription();
            Console.WriteLine("Cette voiture " + essieu + ", il a " + this.nbrEssieux + "essieux");
        }*/

        public override void getDescription()
        {
            string essieu = (this.semi) ? " est semi camion " : "c'est camion";
            Console.WriteLine("Ce véhicule est une marque : {0} et de modèle : {1}, il est construit en {2}", this.marque, this.modele, this.anneeConstruction);
            Console.WriteLine("Cette voiture " + essieu + ", il a " + this.nbrEssieux + "essieux");
        }
    }
}
