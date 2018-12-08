using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp9.cs
{
    public class Program
    {
        public static void Main()
        {
            locomotive lo = new locomotive("1024",19,"123321tu500");
            wagon_passager wp = new wagon_passager(100,"meliteur",50,"32123tu102");
            wagon_marchandise wm= new wagon_marchandise(20,100,"321123tu134");
            train t = new train(lo,"sud-nord");
            t.ajouter_wagon(wp);
            t.ajouter_wagon(wm);
            t.affiche();
            wp.monter(3);
            wp.descendre(1);
            wp.affiche();
            wm.charger(5);
            wm.decharger(2);
            wm.affiche();
            Console.WriteLine("capacite totale du train :   " + t.capacite_totale());

        }
    }
}
