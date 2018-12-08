using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4CamaraLabyDamaro
{
    public class Program
    {
        public static void Main()
        {
            Article a = new Article();
            Article a2 = new Article(1, 22, 4);
            Article a3 = new Article(1, 50, 8);

            List<Article> la = new List<Article>();

            la.Add(a);
            la.Add(a2);
            la.Add(a3);

            Ticket t = new Ticket(1, 7, la);
            Ticket t2 = new Ticket(2, 2, la);

            List<Ticket> lt = new List<Ticket>();
            lt.Add(t);
            lt.Add(t2);
            t.calculerAfficherTotalPrix();

            Caisse c = new Caisse();
            c.afficherBilan();
    

            Console.WriteLine("===== Menu =======\n1 - Initialiser la caisse\n2 - Afficher le bilan\n3 - Quitter");

            String test = "";
            while (test != "3")
            {
                Console.WriteLine("Voulez-vous continuer Oui/Non(3) : \n");
                test = Console.ReadLine();
                switch (test)
                {
                    case "1":
                        {
                            Console.WriteLine("Donnez le nombre d'article : \n");
                            int nbr = int.Parse(Console.ReadLine());
                            for (int i = 0; i < nbr; i++)
                            {
                                Console.WriteLine("Donnez l'id de l'article : \n"+(i+1));
                                int idA = int.Parse(Console.ReadLine());
                                Console.WriteLine("Donnez le prix de l'article : \n" + (i + 1));
                                double p = double.Parse(Console.ReadLine());
                                Console.WriteLine("Donnez la quantité de l'article : \n" + (i + 1));
                                int q = int.Parse(Console.ReadLine());
                                a = new Article(idA,p,q);
                                la.Add(a);
                            }
                            c.init_caisse(nbr, 1584, a);
                        }; break;
                    case "2":
                    {
                        c.afficherBilan();
                    };break;

                    case "3":
                        {
                            
                        }; break;
                }
            }

        }
    }
}
