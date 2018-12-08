using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevoirDeControlePOO
{
    class Agenda
    {
        private string id;

        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        private int annee;

        public int ANNEE
        {
            get { return annee; }
            set { annee = value; }
        }

        private string proprietaire;

        public string PROPRIETAIRE
        {
            get { return proprietaire; }
            set { proprietaire = value; }
        }

        public List<Evenement> listEvent;

        public Agenda(string id,int annee,string proprietaire)
        {
            this.id = id;
            this.annee = annee;
            this.proprietaire = proprietaire;
            listEvent = new List<Evenement>();
        }

        public int NbEvent()
        {
            return listEvent.Count;
        }

        public bool AjouterEvent(Evenement ev)
        {
            bool result = false;

            /*foreach (Evenement e in listEvent)
            {
                if(!(e.TITRE == ev.TITRE) && !(e.DATEDEDEBUT == ev.DATEDEDEBUT) && !(e.DATEDEFIN == ev.DATEDEFIN))
                {
                    listEvent.Add(ev);
                    result = true;
                }
                
            }*/

            if(!(listEvent.Exists(mmm => mmm.TITRE == ev.TITRE)))
            {
                listEvent.Add(ev);
                result = true;
            }

           
            return result;
        }

        public int SupprimerEvent(string titre)
        {
            int result = -1;
            Evenement ee;
            ee = listEvent.Find(e =>e.TITRE == titre);
            if(ee != null)
            {
                listEvent.Remove(ee);
                result = 0;
            }
            return result;
        }

        public int EventMois(int mois)
        {
            int result = -1;
            /*foreach (Evenement e in listEvent)
            {*/
                if (listEvent.Exists(e =>e.DATEDEDEBUT.Month == mois))
                {
                    listEvent.Find(e => e.DATEDEDEBUT.Month == mois).afficher();
                    result = 0;
                }
           // }
            return result;
        }


        public int EventJour(int jour)
        {
            int result = -1;
            foreach (Evenement e in listEvent)
            {
                if (e.DATEDEDEBUT.Day == jour)
                {
                    e.afficher();
                    result = 0;
                }
            }
            return result;
        }


        public void AfficherAgenda()
        {
            Console.WriteLine("Identifiant de l'agenda est : {0}\nAnnée de l'agenda : {1}\nLe propriétaire de l'agenda : {2}", this.id, this.annee, this.proprietaire);
            Console.WriteLine("Les évènements déroulés dans cet agenda sont :\n");
            foreach (Evenement e in listEvent)
            {
                e.afficher();
            }
        }
    }
}
