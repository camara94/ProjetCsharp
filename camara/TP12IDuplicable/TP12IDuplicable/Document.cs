using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP12IDuplicable
{
   abstract class Document :IDuplicable
    {
        protected Editeur ed;

        public Editeur ED
        {
            get { return ed; }
            set { ed = value; }
        }

        public Document(Editeur e)
        {
            this.ed = e;
        }

        public virtual void afficheInfo()
        {
            Console.WriteLine("Nom de l'éditeur : {0}\nAdresse de l'éditeur : {1}", this.ed.NOM, this.ed.ADR);
        }

        public abstract Object dupliquer();
    }
}
