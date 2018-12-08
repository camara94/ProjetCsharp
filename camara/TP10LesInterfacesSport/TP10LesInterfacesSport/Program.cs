using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP10LesInterfacesSport
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            List<Equipe> listeEquipes = new List<Equipe> { new Equipe("equip 1",3), new Equipe("equip 2", 5), new Equipe("equip 3", 8),new Equipe("Feu bleu",10) };
            SportAvecBall sab = new SportAvecBall("HandBall", "moins de 21", listeEquipes);
            sab.DIAMETRE = 30;
            sab.POIDS = 4;
            sab.afficherCaracteristiques();
        }
    }
}
