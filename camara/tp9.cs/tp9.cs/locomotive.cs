using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp9.cs
{
    class locomotive:wagon
    {
        private string energie;
        private int puissance;



        public string Energie
        {
            get { return energie; }
            set { energie = value; }
        }


        public int Puissace
        {
            get { return puissance; }
            set { Puissace = value; }
        }


        public locomotive(string e, int p,string mat)
            : base(mat)
        {
            energie = e;
            puissance = p;
        }


        public override void affiche()
        {
            Console.WriteLine("energie: "+energie+"  puissace:"+puissance+"  matricule:"+matricule);
        }




    }
}
