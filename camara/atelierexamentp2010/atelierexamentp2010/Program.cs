using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atelierexamentp2010
{
    public class Program
    {
        public static void Main()
        {
            clientmorale c1 = new clientmorale("djerba-midoun","mohamed","raison sociale",5);
            clientmorale c2 = new clientmorale("djerba-midoun", "mohamed", "raison sociale", 2);
            clientphysique cp3= new clientphysique("houmt-souk","ali",3);
            clientphysique cp4 = new clientphysique("houmt-souk", "ali", 4);
            listeclient lc = new listeclient();
            lc.ajouterclient(c1);
            lc.ajouterclient(c2);
            lc.ajouterclient(cp3);
            lc.ajouterclient(cp4);
            lc.affichelistecl();
            lc.Sort();
        }
    }
}
