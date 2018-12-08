using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4CamaraLabyDamaro
{
    class Ticket
    {
        private DateTime dateTick;
        private int id;
        private int idTicker;
        public List<Article> lAt;

        public Ticket()
        {
            this.dateTick = new DateTime();
            this.id = 0;
            this.idTicker = 0;
            this.lAt = new List<Article>();
        }

        public Ticket(int id,int idTicker,List<Article> la)
        {
            this.dateTick = new DateTime();
            this.id = id;
            this.idTicker = idTicker;
            this.lAt = la ;
        }

        public int IDTICKET
        {
            get { return this.idTicker; }
        }

        public void ajouterArticle(Article a)
        {
            this.lAt.Add(a);
        }

        public void calculerAfficherTotalPrix()
        {
            double prixT = 0;
            foreach (Article a in lAt)
            {
                prixT += a.PRIXU;
            }
            Console.WriteLine("Le prix total est : {0}", prixT);
        }

        public void supprimerArticle(int i)
        {
            if(lAt.Count<i)
            {
                lAt.Remove(lAt[i]);
            }
        }
    }
}
