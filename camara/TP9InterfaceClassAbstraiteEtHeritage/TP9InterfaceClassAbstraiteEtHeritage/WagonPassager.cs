using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP9InterfaceClassAbstraiteEtHeritage
{
    class WagonPassager:Wagon
    {
        private int capacite;

        public int CAPACITE
        {
            get { return capacite; }
            set { capacite = value; }
        }

        private string classe;

        public string CLASSE
        {
            get { return classe; }
            set { classe = value; }
        }

        private int nbrPlace;

        public int NBRPLACE
        {
            get { return nbrPlace; }
            set { nbrPlace = value; }
        }
        
        public WagonPassager(string matricule,int capacite,string classe,int nbrPlace):base(matricule)
        {
            this.capacite = capacite;
            this.classe = classe;
            this.nbrPlace = nbrPlace;
        }
        
        public bool monter(int nbre)
        {
            if(this.nbrPlace > nbre)
            {
                this.nbrPlace += nbre;
                return true;
            }
            return false;
        }


        public bool descendre(int nbre)
        {
            if (this.nbrPlace > nbre)
            {
                this.nbrPlace += nbre;
                return true;
            }
            return false;
        }
        public override void afficher()
        {
            Console.WriteLine("Matricule : {0}\nCapacité : {1}\nNombre de place : {2}\nLa classe : {3}", this.matricule, this.capacite, this.nbrPlace,this.classe);
        }
    }
}
