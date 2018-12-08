using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP10LesInterfacesSport
{
    class SportAvecBall : Sport,IBall
    {
        private double diametre;
        private double poids;
        public SportAvecBall(string nom, string categorie,List<Equipe> eq) : base(nom, categorie,eq)
        {
           
        }

        public double DIAMETRE
        {
            get
            {
               return this.diametre;
            }

            set
            {
                this.diametre = value;
            }
        }

        public double POIDS
        {
            get
            {
                return this.poids;
            }

            set
            {
                this.poids = value;
            }
        }

        public override void afficherCaracteristiques()
        {
            base.afficherCaracteristiques();
            Console.WriteLine("Poids du ballon : " + this.poids + " kilogramme Diamètre du ballon : " + this.diametre + " centimètres");
        }

    }
}
