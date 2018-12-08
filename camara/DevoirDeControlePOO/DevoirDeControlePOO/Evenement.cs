using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevoirDeControlePOO
{
    class Evenement
    {
        private static int n = 0;
        private string titre;

        public string TITRE
        {
            get { return titre; }
            set { titre = value; }
        }

        private int id;

        public int ID
        {
            get { return id; }
            
        }

        private DateTime dateDeDebut;

        public DateTime DATEDEDEBUT
        {
            get { return dateDeDebut; }
            set { dateDeDebut = value; }
        }


        private DateTime dateDeFin;

        public DateTime DATEDEFIN
        {
            get { return dateDeFin; }
            set { dateDeFin = value; }
        }


        private string description;

        public string DESCRIPTION
        {
            get { return description; }
            set { description = value; }
        }
        
        public Evenement(string titre,DateTime debut,DateTime fin,string desc)
        {
            n++;
            this.id = n;
            this.titre = titre;
            this.dateDeDebut = debut;
            this.dateDeFin = fin;
            this.description = desc;
        }

        public Evenement(Evenement ev)
            : this(ev.titre,ev.dateDeDebut,ev.dateDeFin,ev.description)
        {
        }

        public void afficher()
        {
            Console.WriteLine("Evènement N° {0}:\nTitre :{1}\nDate de début : {2}\nDate de fin : {3}\nDescription : {4} ", this.id, this.titre, this.dateDeDebut, this.dateDeFin, this.description);
        }
    }
}
