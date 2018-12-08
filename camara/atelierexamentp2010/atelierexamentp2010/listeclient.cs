using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atelierexamentp2010
{
    class listeclient:List<client>
    {

        



        public  void affichelistecl()
        {
            for (int i = 0; i < this.Count; i++)
            {
               this[i].affiche();
            }
        }




        public void ajouterclient(client c)
        {
            this.Add(c);
        }





    }
}
