using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atelierexamentp2010
{
    abstract class client : IComparable
    {
        protected string adr;
        protected int idcl;

        public string Adr
        {
            get { return adr; }
            set { adr = value; }
        }


        public int Idcl
        {
            get { return idcl; }
            set { idcl = value; }
        }


        public client(string a,int i)
        {
            adr = a;
            idcl = i;
        }

        public abstract void affiche();

        public int CompareTo(object o)
        {
            client c = o as client;
            if (this.idcl < c.idcl)
            {
                return -1;
            }
            if(this.idcl>c.idcl)
            {
                return 1;
            }
            return 0;


        }








    }
}
