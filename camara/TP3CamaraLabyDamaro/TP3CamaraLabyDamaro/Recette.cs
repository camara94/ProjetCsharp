using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3CamaraLabyDamaro
{
    class Recette
    {
        private String nom;
        private int nbreIngMax=5;
        private int nbreEtapMax=5;

        public List<Ingredient> ing;
        public List<Etape> etap;

        public Recette(String nom,List<Ingredient> ing1,List<Etape> eta1)
        {
            this.nom = nom;
            this.ing = ing1;
            this.etap = eta1;
        }

        public Boolean ajouterEtape(Etape etape)
        {
            Boolean result = false;
            if (this.etap.Count > nbreEtapMax)
            {
                this.etap.Add(etape);
                result = true;
                return result;
            }else
            {
                return result;
            }
        }

        public Boolean ajouterIngredient(Ingredient ingredient)
        {
            Boolean result = false;
            if (this.ing.Count < nbreIngMax)
            {
                this.ing.Add(ingredient);
                result = true;
                return result;
            }
            else
            {
                return result;
            }
        }


        public void afficher()
        {
            Console.WriteLine("Nom Recette : {0}\n", this.nom);
            Console.WriteLine("============== Etapes ({0})=================", this.ing.Count);
            for (int i = 0; i < this.ing.Count; i++)
            {
                etap[i].afficher();
            }
            Console.WriteLine("============== Etapes ({0})=================", this.etap.Count);
            foreach(Etape ee in etap)
            {
                
                ee.afficher();
            }    
        }
    }
}
