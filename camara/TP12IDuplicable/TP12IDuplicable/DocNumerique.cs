using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP12IDuplicable
{
    class DocNumerique : Document
    {
        private float volumeOk;

        public float VOLUMEOK
        {
            get { return volumeOk; }
            set { volumeOk = value; }
        }
        

        public DocNumerique(Editeur ed,float vo) : base(ed)
        {
            this.volumeOk = vo;
        }


        public override void afficheInfo()
        {
            base.afficheInfo();
            Console.WriteLine("Volume Ok : " + this.volumeOk);
        }

        public override object dupliquer()
        {
            return this;
        }
    }
}
