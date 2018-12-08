using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP12IDuplicable
{
    class DocPapier : Document
    {
         private int nbPages;

        public int NBPAGES
        {
            get { return nbPages; }
            set { nbPages = value; }
        }


        public DocPapier(Editeur ed, int np)
            : base(ed)
        {
            this.nbPages = np;
        }


        public override void afficheInfo()
        {
            base.afficheInfo();
            Console.WriteLine("Le nombre de pages est : " + this.nbPages);
        }

        public override object dupliquer()
        {
            //Editeur e = new Editeur(this.ed.NOM, this.ed.ADR);
            return this;
        }
    }
}
