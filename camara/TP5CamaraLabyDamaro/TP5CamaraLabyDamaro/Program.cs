using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5CamaraLabyDamaro
{
    public class Program
    {
        public static void Main()
        {
            List<Medicament> lm = new List<Medicament>();
            Medicament m1 = new Medicament("asprine", 254, 10);
            Medicament m2 = new Medicament("quinine", 54, 10);
            Medicament m3 = new Medicament("asp", 25, 10);
            Medicament m4 = new Medicament("qui", 94, 18);
            lm.Add(m1);
            lm.Add(m2);
            lm.Add(m3);
            lm.Add(m4);

            List<Client> lc = new List<Client>();
            Client c1 = new Client("Camara", 0);
            Client c2 = new Client("Condé", 150);
            Client c3 = new Client("Cissé", 85);
            lc.Add(c1);
            lc.Add(c2);
            lc.Add(c3);
            Pharmacie ph = new Pharmacie(lc,lm);
            Console.WriteLine("========= Menu =============\n1 - Servir un Client\n2 - Ajouter un médicament\n3 - Ajouter un client\n4 - Afficher le Médicament\n5 - Afficher le Clients\n6 - Approvisionner un médicament");
            String menu = "";
            menu = Console.ReadLine();
            switch(menu)
            {
                case "1":
                    {


                        Console.WriteLine("Donnez le nom du médicament : ");
                        String nom = Console.ReadLine();
                        Console.WriteLine("Donnez le prix du médicament : ");
                        double prix = double.Parse(Console.ReadLine());
                        Console.WriteLine("Donnez la quantité de stock du médicament : ");
                        int q = int.Parse(Console.ReadLine());
                        Medicament m = new Medicament(nom, prix, q);

                        Console.WriteLine("Donnez le nom du Client : ");
                        String no = Console.ReadLine();
                        Console.WriteLine("Donnez le crédit du client : ");
                        double q1 = double.Parse(Console.ReadLine());
                        Client c = new Client(no, q1);

                        while (!ph.lmed.Exists(mmm => mmm.NOM == m.NOM) || !ph.lClient.Exists(mmm => mmm.NOM == c.NOM))
                        {
                            Console.WriteLine("Veuillez donner un nom existant dans notre liste client : ");
                            nom = Console.ReadLine();
                        }

                        if (!ph.lmed.Exists(mmm => mmm.NOM == m.NOM) || !ph.lClient.Exists(mmm => mmm.NOM == c.NOM))
                        {
                            ph.lireMedicament(m);
                            ph.lireClient(c);
                            ph.traiter(m, c);
                        }

                    };break;

                case "2":
                    {
                        Console.WriteLine("Donnez le nom du médicament : ");
                        String nom = Console.ReadLine();
                        Console.WriteLine("Donnez le prix du médicament : ");
                        double prix = double.Parse(Console.ReadLine());
                        Console.WriteLine("Donnez la quantité de stock du médicament : ");
                        int q = int.Parse(Console.ReadLine());
                        Medicament m = new Medicament(nom, prix, q);
                        ph.lireMedicament(m);
                    };break;

                case "3":
                    {
                        Console.WriteLine("Donnez le nom du Client : ");
                        String no = Console.ReadLine();
                        Console.WriteLine("Donnez le crédit du client : ");
                        double q1 = double.Parse(Console.ReadLine());
                        Client c = new Client(no, q1);
                        ph.lireClient(c);
                    };break;
                case "4":
                    {
                        Console.WriteLine("Donnée le nom du médicament : ");
                        String nom = Console.ReadLine();
                        if(ph.lmed.Exists(mmm => mmm.NOM == nom))
                        {
                            ph.lmed.Find(mmm => mmm.NOM == nom).afficher();
                        }
                    };break;
                case "5":
                    {
                        Console.WriteLine("Donnée le nom du médicament : ");
                        String nom = Console.ReadLine();
                        if (ph.lClient.Exists(mmm => mmm.NOM == nom))
                        {
                            ph.lClient.Find(mmm => mmm.NOM == nom).afficher();
                        }
                    }; break;
                case "6":
                    {
                        Console.WriteLine("Donnée le nom du médicament à augmenter : ");
                        String nom = Console.ReadLine();
                        if(ph.lmed.Exists(mmm => mmm.NOM == nom))
                        {
                            ph.approvisionner(ph.lmed.Find(mmm => mmm.NOM == nom));
                        }
                    };break;
            }
        }
    }
}
