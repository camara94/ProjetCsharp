using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeritageEtPolymorphisme
{
    public abstract class CVehicule
    {

        protected string immatriculation;

        public string IMMATRICULATION
        {
            get { return immatriculation; }
            set { immatriculation = value; }
        }


        protected int anneeConstruction;

        public int ANNEECONSTRUCTION
        {
            get { return anneeConstruction; }
            set { anneeConstruction = value; }
        }

        protected string marque;

        public string MARQUE
        {
            get { return marque; }
            set { marque = value; }
        }

        protected string modele;

        public string MODELE
        {
            get { return modele; }
            set { modele = value; }
        }
        

        public CVehicule()
        {
            this.anneeConstruction = 0;
            this.marque = "";
            this.modele = "";
        }

        public CVehicule(int a,string im,string marq,string model)
        {
            this.anneeConstruction = a;
            this.marque = marq;
            this.modele = model;
            this.immatriculation = im;
        }


        public abstract void getDescription();
        
    }
}
