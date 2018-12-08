using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace TP5CamaraLabyDamaro
{
    class Pharmacie
    {
        public List<Medicament> lmed;
        public List<Client> lClient;

        public Pharmacie()
        {
            lClient = null;
            lmed = null;
        }
        public Pharmacie(List<Client> lc,List<Medicament> lm)
        {
            lClient = lc;
            lmed = lm;
        }

        public void afficher()
        {
            foreach (Client c in lClient)
            {
                c.afficher();
            }
            foreach (Medicament m in lmed)
            {
                m.afficher();
            }
        }

        public void lireMedicament(Medicament m)
        {
            lmed.Add(m);
        }

        public void lireClient(Client c)
        {
            lClient.Add(c);
        }

        public bool approvisionner(Medicament m)
        {
            bool b = false;
           if(lmed.Exists(mmm =>mmm.NOM==m.NOM))
           {
               
               lmed.Add(m);
               b = true;
           }
         
           return b;
        }

        public void traiter(Medicament me,Client c)
        {    
              if (lmed.Exists(mmm => mmm.NOM == me.NOM) && lmed.Exists(cc => cc.NOM == c.NOM))
              {
                    lmed.Remove(me);
                    c.CREDIT += me.PRIX;
              }
        }


    }
}
