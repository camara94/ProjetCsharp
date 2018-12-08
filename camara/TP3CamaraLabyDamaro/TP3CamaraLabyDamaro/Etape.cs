using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3CamaraLabyDamaro
{
    class Etape
    {
        
        private int numero;
        private String description;

        public Etape()
        {
            this.numero = 0;
            this.description = "";
        }

        public Etape(int num,String desc)
        {
            this.numero = num;
            this.description = desc;
        }

        public int NUMERO
        {
            get { return this.numero; }
            set { this.numero = value; }
        }

        public String DESCRIPTION
        {
            get { return this.description; }
            set { this.description = value; }
        }

        public void afficher()
        {
            Console.WriteLine("#{0}, {1}", this.numero, this.description);
        }
    }
}
