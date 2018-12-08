using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevoirDeSynthesePOO
{
    class VoyageShopping : Voyage
    {
        List<Boutique> listesBoutique = new List<Boutique>();
        public VoyageShopping(int num, string villesDest, string villeDep, DateTime dateDep, int duree, string nomResp, Boutique boutique)
            : base(num, villesDest, villeDep, dateDep, duree, nomResp)
        {
            this.listesBoutique.Add(boutique);
        }
        public override void afficheInfo()
        {
            base.afficheInfo();
            foreach(Boutique boutique in listesBoutique)
            {
                boutique.afficher();
            }
        }
    }
}
