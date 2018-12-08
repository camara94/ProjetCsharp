using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP10LesInterfacesLesFigures
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            List<IFigure> listeFigures = new List<IFigure> { new Cercle(14), new Rectangle(7.5,9), new Rectangle(8.9,10), new Cercle(7.5)};
            Console.WriteLine("Les périmètres : ");
            foreach (IFigure f in listeFigures)
            {
                Console.WriteLine(f.perimetre());
            }
            Console.WriteLine();
            Console.WriteLine("Les surfaces : ");
            foreach (IFigure f in listeFigures)
            {
                Console.WriteLine(f.surface());
            }
            Console.WriteLine();
            //Le plus grand périmètre et surface
            Console.WriteLine("Le plus grand périmètre est : " + listeFigures.Max(r => r.perimetre()));
            Console.WriteLine("La plus grande surface est : " + listeFigures.Max(r => r.surface()));
            //Le plus petit périmètre et surface
            Console.WriteLine("Le plus pétit périmètre est : " + listeFigures.Min(r => r.perimetre()));
            Console.WriteLine("La plus pétite surface est : " + listeFigures.Min(r => r.surface()));

        }
    }
}
