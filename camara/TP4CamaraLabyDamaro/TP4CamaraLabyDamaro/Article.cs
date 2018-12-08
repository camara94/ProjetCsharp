using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4CamaraLabyDamaro
{
    class Article
    {
        private int idArticle;
        private double prixU;
        private int qteCmd;

        public Article()
        {
            this.idArticle = 0;
            this.prixU = 0;

            this.qteCmd = 0;
        }


        public Article(int id,double prix,int qte)
        {
            this.idArticle = id;
            this.prixU = prix;
            this.qteCmd = qte;
        }


        public int IDARTICLE
        {
            get { return this.idArticle; }
            set { this.idArticle = value; }
        }

        public double PRIXU
        {
            get { return this.prixU; }
            set { this.prixU = value; }
        }

        public int QTECMD
        {
            get { return this.qteCmd; }
            set { this.qteCmd = value; }
        }
    }
}
