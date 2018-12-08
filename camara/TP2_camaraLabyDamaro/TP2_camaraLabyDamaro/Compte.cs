using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_camaraLabyDamaro
{
    
    class Compte
    {
        private int numero;
        private static int n = 0;
        private String nom;
        private double solde=0;
        private double decouvMax=500;
        private double debitMax = 800;
        private String typeProp = "Civil";
        private List<String> lop = new List<string>();
        

        public Compte() 
        {
            this.typeProp = "Civil";
            this.solde = 0;
            String txt = "Vous avez créer compte le " + DateTime.Now + "votre solde est de " + this.solde + "DNT";
            lop.Add(txt);
        }
        public Compte(String nom,double solde,String etat) 
        {
            n++;
            String txt="";
            this.nom = nom;
            this.solde = solde;
            this.numero = n;
            this.typeProp = etat;
            txt = "Vous avez créer compte le " + DateTime.Now + "votre solde est de " + this.solde + "DNT";
            lop.Add(txt);
        }

        public double SOLDE
        {
            get { return this.solde; }
            set { this.solde = value; }
        }
        public int Num
        {
            get { return this.numero; }
            set { this.numero = value; }
        }
        public double DECOUVMAX
        {
            get { return this.decouvMax; }
            set { this.decouvMax = value; }
        }

        public double DEBITMAX
        {
            get { return this.debitMax; }
            set { this.debitMax = value; }
        }

        public double crediter(double credit) 
        {
             this.solde += credit;

             String txt = "Vous avez ajouté une somme de " + (credit) + "DNT,votre solde est de " + this.solde + "DNT" + " : " + DateTime.Now;
             lop.Add(txt);

            return this.solde;
        }

        public int debiter(double debit)
        {
            String txt;
            double ns = this.solde - debit;
            if (ns < 0)
                if (Math.Abs(ns) < decouvMax)
                {
                    solde = ns;
                    txt = "Vous avez rétiré une somme de " + (debit) + "DNT,votre solde est de " + this.solde + "DNT" + " : " + DateTime.Now;
                    lop.Add(txt);
                    return 0;  //operation effectuée avec decouvert
                }
                else
                {
                    return -1;//Decouvert atteint 
                }
            else
            {
                solde = ns;
                txt = "Vous avez rétiré une somme de " + (debit) + "DNT,votre solde est de " + this.solde + "DNT" + " : " + DateTime.Now;
                lop.Add(txt);
                return 1;//opration réalisée normalement
            }
        }

        public void afficher_extrait()
        {
            foreach (String txt in lop)
            {
                Console.WriteLine(txt);
            }
        }
    }
}
