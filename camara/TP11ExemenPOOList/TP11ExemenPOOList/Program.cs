using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP11ExemenPOOList
{
    public class Program
    {
        public static void Main()
        {
            List<Client> listeClient = new List<Client>();
            ClientPhysique c1 = new ClientPhysique(3, "Camara", "Foyer universitaire Djerba");
            ClientMoral c2 = new ClientMoral(2, "ISET", "rue de ben amor", "raison sociale 1");
            listeClient.Add(c1);
            listeClient.Add(c2);
            //c1.CompareTo(c2);
            listeClient.Sort();
            ListeClient lc = new ListeClient(listeClient);
            lc.afficherListeCl();

            
        }
    }
}
