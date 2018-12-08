using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP10LesInterfacesLesFigures
{
    class Rectangle : Forme
    {
        private double hauteur;
        private double largeur;

        public Rectangle(double hauteur,double largeur):base()
        {
            this.hauteur = hauteur;
            this.largeur = largeur;
        }
        public override double perimetre()
        {
            return 2*(this.largeur + this.hauteur);
        }

        public override double surface()
        {
            return this.hauteur * this.largeur;
        }
    }
}
