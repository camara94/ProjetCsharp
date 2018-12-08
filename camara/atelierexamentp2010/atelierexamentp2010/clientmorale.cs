using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atelierexamentp2010
{
    class clientmorale:client
    {
        private string nomgeran;
        private string raisonsociale;


        public string Nomgeran
        {
            get { return nomgeran; }
            set { nomgeran = value; }
        }




        public string Raisonsociale
        {
            get { return raisonsociale; }
            set { raisonsociale = value; }
        }




        public clientmorale(string n,string r,string a,int i):base(a,i)
        {
            nomgeran = n;
            raisonsociale = r;
        }

        public override void affiche()
        {
            Console.WriteLine("adresse:" + adr + "  id client: " + idcl +"  nom geran:"+nomgeran+"   raison sociale: "+raisonsociale );
        }






    }
}
