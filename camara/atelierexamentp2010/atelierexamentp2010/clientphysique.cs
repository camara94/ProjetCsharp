using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atelierexamentp2010
{
    class clientphysique:client
    {
        private string nomcl;



        public string Nomcl
        {
            get { return nomcl; }
            set { nomcl = value; }
        }

        public clientphysique(string nc,string a,int i):base(a,i)
        {
            nomcl = nc;
        }



        public override void affiche()
        {
            Console.WriteLine("adresse:" +adr+"  id client: "+idcl+"  nom client :"+nomcl);
        }

    }
}
