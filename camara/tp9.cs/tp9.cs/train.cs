using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp9.cs
{
    class train
    {
        private string ligne;
        public List<wagon>lw= new List<wagon>();


        public string Ligne
        {
            get { return ligne; }
            set { ligne = value; }
        }

        public void affiche()
        {
            Console.WriteLine("ligne: " + ligne);
            for (int i = 0; i < lw.Count; i++)
            {
                lw[i].affiche();
            }
        }



        public void ajouter_wagon(wagon w)
        {
            lw.Add(w);
        }


        public train(locomotive lo,string li)
        {
            ligne = li;
            lw.Add(lo);
        }


        public int capacite_totale()
        {
            int c = 0;
            for (int i = 0; i < lw.Count; i++)
            {
                if (lw[i] is wagon_passager)
                {
                     c = c + (lw[i] as wagon_passager).Capacite;
                    
                }
                
            }
            return c;
        }



    }
}
