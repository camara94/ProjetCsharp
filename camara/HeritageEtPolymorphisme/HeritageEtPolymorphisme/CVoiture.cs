using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeritageEtPolymorphisme
{
    class CVoiture:CVehicule
    {

        private bool decapotable;

        public bool DECAPOTABLE
        {
            get { return decapotable; }
            set { decapotable = value; }
        }

        private bool climatisation;

        public bool CLIMATISATION
        {
            get { return climatisation; }
            set { climatisation = value; }
        }
        
        
        public CVoiture(int a,string im,string marq,string model,bool dep,bool clim) :base(a,im,marq,model)
        {
            this.decapotable = dep;
            this.climatisation = clim;
        }

        /*public void getDescription()
        {
            base.getDescription();
            string decap = (this.decapotable) ? " est décapotable " : "n'est pas décapotable";
            string clim = (this.decapotable) ? " est climatisée " : "n'est pas climatisée"; 
            Console.WriteLine("Cette voiture " + decap + ", elle " + clim);
        }*/

        public override void getDescription()
        {
            string decap = (this.decapotable) ? " est décapotable " : "n'est pas décapotable";
            string clim = (this.decapotable) ? " est climatisée " : "n'est pas climatisée";
             Console.WriteLine("Ce véhicule est une marque : {0} et de modèle : {1}, il est construit en {2}", this.marque, this.modele, this.anneeConstruction);
             Console.WriteLine("Cette voiture " + decap + ", elle " + clim);
        }
    }
}
