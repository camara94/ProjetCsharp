using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp9.cs
{
    abstract class wagon
    {
        protected string matricule;


        public string Matricule
        {
            get { return matricule; }
            set { matricule = value; }
        }


      public abstract void affiche();

        public wagon(string m)
        {
            matricule = m;
        }
        

        









    }
}
