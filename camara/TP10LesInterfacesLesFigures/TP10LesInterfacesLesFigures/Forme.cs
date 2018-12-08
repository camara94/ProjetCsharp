using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP10LesInterfacesLesFigures
{
    public abstract class Forme : IFigure
    {
        private int x;

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        private int y;

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public Forme()
        {
            this.x = 0;
            this.y = 0;
        }

        public abstract double perimetre();


        public abstract double surface();
    }
}
