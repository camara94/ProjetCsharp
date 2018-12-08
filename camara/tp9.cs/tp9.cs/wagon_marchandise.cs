using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp9.cs
{
    class wagon_marchandise:wagon
    {
        private int charge;
        private int chargemax;





        public int Chargemax
        {
            get { return chargemax; }
            set { chargemax = value; }
        }


        public int Charge {
            get {return charge; }
            set { if (charge <= chargemax) { charge = value; } }
        }



        public wagon_marchandise(int c, int cm, string mat):base(mat)
        {
            charge = c;
            chargemax = cm;   
        }



        public override void affiche()
        {
            Console.WriteLine("charge: "+charge+"  charge maximale: "+ chargemax+"  matricule :"+matricule);
        }

        public void charger(int c)
        {if(charge+c<=chargemax)
        {
            charge = c;}
        }


        public void decharger(int c)
        {
            if(charge-c>=0)
        {
            charge = c;
        }
            
            
        }









    }
}
