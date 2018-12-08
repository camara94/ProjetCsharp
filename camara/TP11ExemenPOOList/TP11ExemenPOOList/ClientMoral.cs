using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP11ExemenPOOList
{
    class ClientMoral : Client
    {
        private string nomGeran;

        public string NOMGERAN
        {
            get { return nomGeran; }
            set { nomGeran = value; }
        }

        private string raisonSociale;

        public string RAISONSOCIALE
        {
            get { return raisonSociale; }
            set { raisonSociale = value; }
        }
        
        public ClientMoral(int id,string nom,string adr,string raison) : base(id,adr)
        {
            this.nomGeran = nom;
            this.raisonSociale = raison;
        }
        public override void afficher()
        {
            Console.WriteLine("Identifiant : {0}\nNom : {1}\nRaison sociale : {2}\nAdresse : {3}\n", this.idCL, this.nomGeran, this.raisonSociale, this.adr);
        }
    }
}
