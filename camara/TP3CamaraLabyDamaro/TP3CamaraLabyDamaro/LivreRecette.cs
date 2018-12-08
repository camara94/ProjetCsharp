using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3CamaraLabyDamaro
{
    class LivreRecette
    {
        private List<Recette> recet;

        public LivreRecette(List<Recette> rec)
        {
            this.recet = rec;
        }

        public Recette obtenirRecette(int i)
        {
            return this.recet[i];
        }

        public void afficher()
        {
            for (int i = 0; i < this.recet.Count; i++)
            {
                
                this.recet[i].afficher();
            }
        }

        public void supprimerRecette(int i)
        {
            if (i < this.recet.Count)
                this.recet.Remove(this.recet[i]);
            else
                Console.WriteLine("Vous avez depassé la taille de la liste");
        }

        public void ajouterRecette(Recette r)
        {
            this.recet.Add(r);
        }
    }
}
