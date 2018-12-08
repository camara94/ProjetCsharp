using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamaraTous
{
    public class Program
    {
        static void Main()
        {

           
            int continuer = 0;
            while (continuer == 0)
            {
                menu();
                int choix = int.Parse(Console.ReadLine());
                switch (choix)
                {
                    case 1: DevoirSynthesPOOCamara.Program.Main(); break;
                    case 2: HeritageEtPolymorphisme.Program.Main(); break;
                    case 3: DevoirDeControlePOO.Program.Main(); break;
                    case 4: ModelisationObjetDesReseaux.Program.Main(); break;
                    case 5: TP10LesInterfacesLesFigures.Program.Main(); break;
                    case 6: TP10LesInterfacesSport.Program.Main(); break;
                    case 7: TP2_camaraLabyDamaro.Program.Main(); break;
                    case 8: TP11ExemenPOOList.Program.Main(); break;
                    case 9: TP3CamaraLabyDamaro.Program.Main(); break;
                    case 10: TP4CamaraLabyDamaro.Program.Main(); break;
                    case 11: TP5CamaraLabyDamaro.Program.Main(); break;
                    case 12: tp9.cs.Program.Main(); break;
                    case 13: TP9InterfaceClassAbstraiteEtHeritage.Program.Main(); break;
                    case 14: AssociationEtHeritage.Program.Main(); break;
                    case 15: atelierexamentp2010.Program.Main(); break;
                    case 16: TP12IDuplicable.Program.Main(); break;
                    case 17: continuer = 1; break;
                }
            }
            
        }

        public static void menu()
        {
            Console.WriteLine("==================================================================================================\n");
            Console.WriteLine("Bienvenue dans mes projets C#\nVeuiller choisir une option pour lancer un programme");
            Console.WriteLine("1-Devoir de synthèse");
            Console.WriteLine("2- Heritage et Polymorphisme");
            Console.WriteLine("3- Devoir de controle 2018");
            Console.WriteLine("4- Modélisation Réseau");
            Console.WriteLine("5- TP10LesInterfacesLesFigures");
            Console.WriteLine("6- TP10LesInterfacesSport");
            Console.WriteLine("7- TP2_camaraLabyDamaro");
            Console.WriteLine("8- TP11ExemenPOOList");
            Console.WriteLine("9- TP3CamaraLabyDamaro");
            Console.WriteLine("10- TP4CamaraLabyDamaro");
            Console.WriteLine("11- TP5CamaraLabyDamaro");
            Console.WriteLine("12- tp9");
            Console.WriteLine("13- TP9InterfaceClassAbstraiteEtHeritage");
            Console.WriteLine("14- AssociationEtHeritage");
            Console.WriteLine("15- TP9InterfaceClassAbstraiteEtHeritage");
            Console.WriteLine("16- TP12IDuplicable");
            Console.WriteLine("17- Quitter");  
        }
    }
}
