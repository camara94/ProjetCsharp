using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP10LesInterfacesSport
{
    public interface IBall
    {
        double POIDS { get; set; }
        double DIAMETRE { get; set; }

        void afficherCaracteristiques();
    }
}
