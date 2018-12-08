using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP11ExemenPOOList
{
    class ClientPhysique : Client
    {
         private string nomGeran;

        public string NOMGERAN
        {
            get { return nomGeran; }
            set { nomGeran = value; }
        }        
        public ClientPhysique(int id,string nom,string adr) : base(id,adr)
        {
            this.nomGeran = nom;
        }
        public override void afficher()
        {
            Console.WriteLine("Identifiant : {0}\nNom : {1}\nAdresse : {2}\n", this.idCL, this.nomGeran, this.adr);
        }
    }
}
