using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationEtHeritage
{
    public class Program
    {
        static void Main(string[] args)
        {
            Service service = new Service(1, "Programme Informatique");
            Directeur directeur = new Directeur("Re10", "Monsieur Ourir", "administrateur", service, 4, "informatique");
            Employe employe1 = new Employe("ie40", "Monsieur Monchef", "sécretaire",service);
            Employe employe2 = new Employe("oe70", "Monsieur Rabii", "Chargé des cours",service);
           
           List<Employe> listEmployes = new List<Employe>();
            listEmployes.Add(employe1);
            listEmployes.Add(employe2);
            listEmployes.Add(directeur);
            foreach(Employe e in listEmployes)
            {
                e.afficher();
            }

            
            
        }
    }
}
