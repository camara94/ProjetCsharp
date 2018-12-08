using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP9InterfaceClassAbstraiteEtHeritage
{
    public class Program
    {
        public static void Main()
        {
            WagonMarchandise wm = new WagonMarchandise("11AD", 1250, 8000);
            WagonPassager wp = new WagonPassager("RJ05",5868,"classe 1", 562);
            Locomotive lo = new Locomotive("RGjk", "energie de force",1452);

            Train tr = new Train(lo, "La ligne 2");
            tr.ajouterWagon(wp);
            tr.ajouterWagon(wm);
            tr.afficher();

        }
    }
}
