using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP11ExemenPOOList
{
    public abstract class Client : IComparable
    {
        protected String adr;

        public String ADR
        {
            get { return adr; }
            set { adr = value; }
        }

       protected int idCL;

        public int IDCL
        {
            get { return idCL; }
            set { idCL = value; }
        }

        public Client(int id,string adr)
        {
            this.adr = adr;
            this.idCL = id;
        }

        public  int CompareTo(Object o)
        {
           Client c = o as Client;
            if (this.IDCL < c.IDCL)
            {
                return -1;
            }
            else if (this.IDCL > c.IDCL)
            {
                return 1;
            }


            return 0;
            
        }
        public abstract void afficher();


    }
}
