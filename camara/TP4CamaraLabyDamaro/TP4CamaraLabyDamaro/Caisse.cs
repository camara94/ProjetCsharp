using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4CamaraLabyDamaro
{
    class Caisse
    {
        private List<String> lop = new List<string>();
        private List<Ticket> ltick = new List<Ticket>();
        private double montant;
        private double montant_init;
        private List<Article> listArt = new List<Article>();

        public Caisse()
        {
            this.ltick = new List<Ticket>();
            this.listArt = new List<Article>();
            this.montant = 0;
            this.lop.Add("==Bienvenue à la caisse==\n");
        }
        public Caisse(List<Ticket> lt,List<Article> la,double mont)
        {
            this.ltick = lt;
            this.listArt = la;
            this.montant = mont;
            this.lop.Add("==Bienvenue à la caisse==\n");
        }

        public void remplirListeArticle(Article a)
        {
            this.listArt.Add(a);
            this.lop.Add("Vous avez ajouté l'article :" +a.IDARTICLE+ "prix :"+a.PRIXU+" et la quantité : " + a.QTECMD);
        }

        public void afficherBilan()
        {
            foreach(Ticket t in this.ltick)
            {
                Console.WriteLine("Ticket {0} le nombre d'article est {1} et le prix total est :", t.IDTICKET, t.lAt.Count);
                t.calculerAfficherTotalPrix();
            }
        }

        public void init_caisse(double argent, int nba,Article a)
        {
            this.montant_init = argent;
            this.lop.Add("Vous avez initialisé votre compte a :" + this.montant_init+"le solde est : " + this.montant);
            //lire nb Article -boucler en appelant ajouter article
            for(int i=0;i<nba;i++){
                this.remplirListeArticle(a);
            }
        }
        public void retirer(double argent)
        {
            this.montant -= argent;
            this.lop.Add("Vous avez rétiré une somme de :" + argent + "le solde est : " + this.montant);
        }

        public void servirClient()
        {
            
                Console.WriteLine("Donnez l'id de l'article : \n");
                int idA = int.Parse(Console.ReadLine());
                Console.WriteLine("Donnez la quantité de l'article : \n");
                int q = int.Parse(Console.ReadLine());
                if (listArt.Exists(i => idA == listArt[idA].IDARTICLE))
                {

                Console.WriteLine("Vous avez servit le " + listArt.Find(i => idA == listArt[idA].IDARTICLE).ToString());
                }
     
        }

        public void verser(double argent)
        {
            this.montant = argent;
            this.lop.Add("Vous avez versé une somme de " + argent);
        }


    }
}
