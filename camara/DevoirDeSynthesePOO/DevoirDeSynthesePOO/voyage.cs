using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevoirDeSynthesePOO
{
    class Voyage:IVoyage,IComparable
    {
        private int numero;

        public int NUMERO
        {
            get { return numero; }
            set { numero = value; }
        }

        private string villeDestination;

        public string VILLEDESTINATION
        {
            get { return villeDestination; }
            set { villeDestination = value; }
        }

        private string villeDepart;

        public string VILLEDEPART
        {
            get { return villeDepart; }
            set { villeDepart = value; }
        }

        private DateTime dateDepart;

        public DateTime DATEDEPART
        {
            get { return dateDepart; }
            set { dateDepart = value; }
        }

        private int duree;

        public int DUREE
        {
            get { return duree; }
            set { 
                    if(value>0)
                        duree = value;
                    Console.WriteLine("la durée doit être supérieur à 0");
            }
        }


        private string nomResponsable;

        public string NOMRESPONSABLE
        {
            get { return nomResponsable; }
            set { nomResponsable = value; }
        }
        
        public Voyage(int num,string villesDest,string villeDep,DateTime dateDep,int duree,string nomResp)
        {
            this.numero = num;
            this.villeDestination = villesDest;
            this.villeDepart = villeDep;
            this.dateDepart = dateDep;
            this.duree = duree;
            this.nomResponsable = nomResp;
        }

        public virtual void afficheInfo()
        {
            Console.WriteLine("Voici les caracteristiques de ce voyage :\nNumero : {0}\nVille de destination : {1}\nVille de depart : {2}\nDurée : {3}\nResponsable est : {4} ",this.numero,this.villeDestination,this.villeDepart,this.duree,this.nomResponsable);
        }

        public int CompareTo(Object o)
        {
            Voyage v = o as Voyage;
            return this.villeDestination.CompareTo(v.villeDestination);
        }
    }
}
