using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_camaraLabyDamaro
{
    public class Program
    {
        public static void Main()
        {
            operation();
        }

        public static void operation()
        {
            List<Compte> listCompte = new List<Compte>();
            Compte user1;

            Console.WriteLine("===== Menu ======");
            Console.WriteLine("1.Créer un compte");
            Console.WriteLine("2.Crediter un compte");
            Console.WriteLine("3.Debiter un compte");
            Console.WriteLine("4.Afficher les opération sur le compte");
            Console.WriteLine("5.Quitter");
            int n=1;
            while (n != 0) 
            {
                Console.WriteLine("Faites votre choix : ");
                int i = int.Parse(Console.ReadLine());
                switch(i)
                {
                    case 1: Console.WriteLine("Donnez le nom : ");
                    String nom = Console.ReadLine();
                    Console.WriteLine("Donnez le solde : ");
                    double solde = double.Parse(Console.ReadLine());
                     user1 = new Compte(nom, solde, "Civil");
                    listCompte.Add(user1);
                    break;

                    case 2: 
                        Console.WriteLine("Donnez le numero de compte: ");
                        int nnn = int.Parse(Console.ReadLine());
                        user1=listCompte.Find(c =>c.Num==nnn);
                        Console.WriteLine("Donnez le montant créditer: ");
                        double sold = double.Parse(Console.ReadLine());
                        user1.crediter(sold);break;

                    case 3: 
                        Console.WriteLine("Donnez le numero de compte: ");
                        int nnn1 = int.Parse(Console.ReadLine());
                        user1=listCompte.Find(c =>c.Num==nnn1);
                        Console.WriteLine("Donnez le montant à debiter :");
                        double sold1 = double.Parse(Console.ReadLine());
                        user1.crediter(sold1);break;

                    case 4:
                        Console.WriteLine("Donnez le numero de compte: ");
                        int nnn2 = int.Parse(Console.ReadLine());
                        user1 = listCompte.Find(c => c.Num == nnn2);
                        user1.afficher_extrait();
                        break;

                    case 5:  n = 5;break;
                }
                
            } 
            /*Console.WriteLine("Bienvenue dans notre banque, voici vos derniers opérations éffectuée : \n");
            Compte user1 = new Compte("Camara", 2548, "Civil");
            user1.crediter(145);
            user1.debiter(150);
            user1.afficher_extrait();*/
        }
    }
}
