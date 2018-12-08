using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevoirSynthesPOOCamara
{
    class VoyageEtude : Voyage
    {
        private string sujetDetude;

        public string SUJETDETUDE
        {
            get { return sujetDetude; }
            set { sujetDetude = value; }
        }

        public VoyageEtude(int num, string villesDest, string villeDep, DateTime dateDep, int duree, string nomResp, string sujetDetude)
            : base(num, villesDest, villeDep, dateDep, duree, nomResp)
        {
            this.sujetDetude = sujetDetude;
        }

        public override void afficheInfo()
        {
            base.afficheInfo();
            Console.WriteLine("Le sujet d'étude est : " + this.sujetDetude);
        }

    }
}
