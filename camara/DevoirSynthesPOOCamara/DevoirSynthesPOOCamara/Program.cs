using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevoirSynthesPOOCamara
{
    public class Program
    {
         static List<Voyage> LVoy = new List<Voyage>();
        public static void Main()
        {
            remplit();
            LVoy.Sort();

            foreach (Voyage v in LVoy)
            {
                v.afficheInfo();
            }
        }

        public static void remplit()
        {
            VoyageEtude ve = new VoyageEtude(125, "Tozer", "Djerba", DateTime.Today, 5, "Camara", "Visite des site de tozer");
            VoyageShopping vs = new VoyageShopping(12, "Bizerte", "Sfax", DateTime.Today, 10, "Aly", new Boutique("artisane", "près de l'ISET de Bijerte", "Une boutique basée sur les oeuvres artistiques"));
            VoyageEtude ve2 = new VoyageEtude(50, "Kebilli", "Djerba", DateTime.Today, 5, "Houda", "Visite des site de Kebilli");

            LVoy.Add(ve);
            LVoy.Add(vs);
            LVoy.Add(ve2);
        }
    }
}
