using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP10LesInterfacesLesFigures
{
    public class Cercle : Forme
    {
        private double rayon;
        public Cercle(double rayon):base()
        {
            this.rayon = rayon;
        }
        public override double perimetre()
        {
            return 2 * Math.PI * rayon;
        }

        public override double surface()
        {
            return Math.PI * Math.Pow(rayon, 2);
        }
    }
}
