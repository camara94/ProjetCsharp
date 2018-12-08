using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP11ExemenPOOList
{
    class ListeClient : List<Client>
    {
        public List<Client> listeClient = new List<Client>();
        public ListeClient(List<Client> lc)
        {
            this.listeClient = lc;
        }

        public void afficherListeCl()
        {
            foreach(Client c in listeClient)
            {
                c.afficher();
            }
        }

        public void ajouterClient(Client c)
        {
            this.listeClient.Add(c);
        }

    }
}
