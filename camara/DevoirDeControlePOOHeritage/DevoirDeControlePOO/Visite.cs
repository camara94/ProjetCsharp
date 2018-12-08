using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevoirDeControlePOO
{
    class Visite : Evenement
    {
        private string destination;

        public string DESTINATION
        {
            get { return destination; }
            set { destination = value; }
        }

        private string depart;

        public string DEPART
        {
            get { return depart; }
            set { depart = value; }
        }

        public Visite(string titre, DateTime debut, DateTime fin, string desc,string dest,string depart) : base(titre, debut, fin, desc)
        {
            this.destination = dest;
            this.depart = depart; 
        }

        public override void afficher()
        {
            Console.WriteLine("Le lieu depart de notre visite est  : " + this.depart);
            base.afficher();
            Console.WriteLine("Et  nous allons terminé notre visite à  : " + this.destination);
        }
    }
}
