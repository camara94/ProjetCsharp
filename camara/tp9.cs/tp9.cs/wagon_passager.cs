using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp9.cs
{
    class wagon_passager:wagon
    {
        private int capacite;
        private string classe;
        private int nbrplace;



        public int Capacite
        {
            get { return capacite; }
            set { capacite = value; }
        }


        public string Classe
        {
            get { return classe; }
            set { classe = value; }
        }




        public int Nbrplace
        {
            get { return nbrplace; }
            set {if(nbrplace<=capacite){ nbrplace = value;} }
        }



        public wagon_passager(int ca, string cl, int nbr, string mat)
            : base(mat)
        {
            capacite = ca;
            classe = cl;
            nbrplace = nbr;
        }


        public override void affiche()
        {
            Console.WriteLine("capacite :"+capacite+"  clase:"+classe+"   nombre des places:"+nbrplace+"  matricule:"+matricule);
        }



        public bool descendre(int n)
        {
            if (nbrplace - n>=0) {
                nbrplace = nbrplace - n;
                return true;
            }

            return false;
            
        }


        public bool monter(int n)
        {
            if(nbrplace+n<=capacite)
            {
                nbrplace = nbrplace + n;
                return true;
            }
            return false;
        }



    }
}
