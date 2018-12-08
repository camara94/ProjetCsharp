using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP10LesInterfacesSport
{
    public interface ISport
    {
        int NBREQUIPE { get; set; }
        string NOM { get;set; }
       string CATEGORIE { get; set; }

        void afficherCaracteristiques();
    }
}
