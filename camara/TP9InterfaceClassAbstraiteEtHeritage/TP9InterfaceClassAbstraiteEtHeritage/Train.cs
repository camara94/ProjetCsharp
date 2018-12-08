using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP9InterfaceClassAbstraiteEtHeritage
{
    class Train
    {
        private string ligne;
        public List<Wagon> listWagon = new List<Wagon>();
        public string LIGNE
        {
            get { return this.ligne; }
            set { this.ligne = value; }
        }

        public Train(Locomotive lo, string ligne)
        {
            this.ligne = ligne;
            this.listWagon.Add(lo);
        }

        public int capaciteTotale()
        {
            int somme = 0;

            foreach(Wagon w in listWagon)
            {
                if(w is WagonPassager)
                {
                    somme += (w as WagonPassager).CAPACITE;
                }
               
            }
            return somme;
        }

        
        public void ajouterWagon(Wagon w)
        {
            listWagon.Add(w);
        }

        public void afficher()
        {
            Console.WriteLine("La ligne : {0}\nLa capacité totale : {1}", this.ligne, capaciteTotale());
            foreach (Wagon w in listWagon)
            {
                w.afficher();
            }
        }

    }
}
