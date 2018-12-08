using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP9InterfaceClassAbstraiteEtHeritage
{
    class WagonMarchandise : Wagon
    {
        private int charge;

        public int CHARGE
        {
            get { return charge; }
            set { charge = value; }
        }

        private int chargeMax;

        public int CHARGEMAX
        {
            get { return chargeMax; }
            set { chargeMax = value; }
        }
        
        public WagonMarchandise(string matricule,int charge,int chargeMax) : base(matricule)
        {
            this.charge = charge;
            this.chargeMax = chargeMax;
        }

        public void charger(int nouvelleCharge)
        {
            if(this.charge + nouvelleCharge<this.chargeMax)
            {
                this.charge += nouvelleCharge;
            }
        }
        public override void afficher()
        {
            Console.WriteLine("Matricule : {0}\nCharge : {1}\nCharge Max : {2}", this.matricule, this.charge, this.chargeMax);
        }
    }
}
