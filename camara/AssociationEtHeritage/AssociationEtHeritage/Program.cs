using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationEtHeritage
{
    public class Program
    {
        public static void Main()
        {
            Directeur directeur = new Directeur("Re10", "Monsieur Ourir", "administrateur", 4, "informatique");
            List<Employe> listEmployes = new List<Employe>();
            Employe employe1 = new Employe("ie40", "Monsieur Monchef", "sécretaire");
            Employe employe2 = new Employe("oe70", "Monsieur Rabii", "Chargé des cours");

            listEmployes.Add(employe1);
            listEmployes.Add(employe2);

            Service service = new Service(1, "Programme Informatique", listEmployes, directeur);
            service.afficher();
            
        }
    }
}
