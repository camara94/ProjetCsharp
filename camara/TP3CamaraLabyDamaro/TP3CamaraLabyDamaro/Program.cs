using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3CamaraLabyDamaro
{
    public class Program
    {
        public static void Main()
        {
            Ingredient i1 = new Ingredient("Pomme tranches", "six", 0.75);
            Ingredient i2 = new Ingredient("Pâte à tarte", "une", 0);
            
            Etape e1 = new Etape(1, "Mettre les pomme sur la tarte");
            Etape e2 = new Etape(2, "Faire chauffer au four 30 minutes à 450");
            Etape e3 = new Etape(3, "Temperer et servir de la crème glacée à la vanille");

            List<Ingredient> li = new List<Ingredient>();
            li.Add(i1);
            li.Add(i2);

            List<Etape> le = new List<Etape>();
            le.Add(e1);
            le.Add(e2);
            le.Add(e3);

            Recette e = new Recette("Tarte aux pommes", li, le);
            List<Recette> lr = new List<Recette>();
            lr.Add(e);
            LivreRecette livreRecette = new LivreRecette(lr);

            Console.WriteLine("0 Quitter\n1 Ajouter Recette\n2 Supprimer Recette\n3 Afficher une Recette\n4 afficher toutes les Recettes");
            string n = "";
            int i = 1;
            while (i != 0)
            {
                Console.WriteLine("Voulez-Vous quitter Oui(0)");
                n = Console.ReadLine();

                switch (n)
                {
                    case "1":
                     {
                         Console.WriteLine("+++++++ Ingrédient ++++++++++ : ");
                         Console.WriteLine("Donnez le nom de l'ingrédient : ");
                         String nomIng = Console.ReadLine();
                         Console.WriteLine("Donnez la quantité de l'ingrédient : ");
                         String quantIng = Console.ReadLine();
                         Console.WriteLine("Donnez le poids de l'ingrédient : ");
                         double poids = double.Parse(Console.ReadLine());

                        Ingredient ing2 = new Ingredient(nomIng, quantIng, poids);

                        Console.WriteLine("+++++++ Ingrédient ++++++++++ : ");
                        Console.WriteLine("Donnez le numéro de réference de l'etape : ");
                        int num = int.Parse(Console.ReadLine());
                        Console.WriteLine("Donnez la description de l'etape : ");
                        String desc = Console.ReadLine();

                        Etape eta2 = new Etape(num, desc);
                        e.ajouterEtape(eta2);
                        e.ajouterIngredient(ing2);
                        lr.Add(e);
                        livreRecette.ajouterRecette(e);
                        };break;

                    case "2":
                    {
                         Console.WriteLine("Veuillez numéro inférieur à {0} pour ne pas depasser la taille du tableau",lr.Count);
                          int nbr = int.Parse(Console.ReadLine());
                         livreRecette.supprimerRecette(nbr);  
                     };break;

                    case "3":
                        {
                            Console.WriteLine("Veuillez numéro inférieur à {0}", lr.Count);
                            int nbr = int.Parse(Console.ReadLine());
                            if (nbr < lr.Count)
                                livreRecette.obtenirRecette(nbr).afficher();
                            else
                                Console.WriteLine("Vous avez dépasser la taille du tableau");
                        }; break;
                    case "4":
                        {
                            livreRecette.afficher();
                        }; break;
                    case "0": Console.WriteLine("zzzz"); i = 0; break;
                }

            }

            /*LivreRecette livreR = new LivreRecette(lr);
            livreR.afficher();*/
           
        }
    }
}
