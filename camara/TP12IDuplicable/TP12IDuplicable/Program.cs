using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP12IDuplicable
{
    public class Program
    {
        private static List<Document> LDoc = new List<Document>();
        
        public static void Main()
        {
            Editeur ed1 = new Editeur("sublimetext", "adresse1");
            DocNumerique dn = new DocNumerique(ed1, 14);
            Editeur ed2 = new Editeur("notepad++", "adresse2");
            DocNumerique dn2 = new DocNumerique(ed2, 17);

            Editeur ed3 = new Editeur("cahier des charge", "adresse23");
            DocNumerique dp = new DocNumerique(ed3, 89);
            ajouterLDoc(dn);
            ajouterLDoc(dn2);
            ajouterLDoc(dp);
            afficherLDoc(LDoc);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Voicila duplication LDoc en LDoc2");
            List<Document> LDoc2 = new List<Document>();
            copierDoc(LDoc2);
            Console.WriteLine();
            Console.WriteLine();
            afficherLDoc(LDoc2);
        }


        private static void afficherLDoc(List<Document> ld)
        {
            foreach(Document d in ld)
            {
                d.afficheInfo();
            }
        }

        private static void ajouterLDoc(Document ld)
        {
            LDoc.Add(ld);
        }

        private static void copierDoc(List<Document> nwList)
        {

           foreach(Document d in LDoc)
           {
                nwList.Add((d.dupliquer() as Document));
           }

        }
    }
}
