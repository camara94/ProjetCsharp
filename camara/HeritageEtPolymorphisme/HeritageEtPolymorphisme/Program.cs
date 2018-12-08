using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeritageEtPolymorphisme
{
    public class Program
    {
        public static void Main()
        {
            List<CVehicule> listVehicules = new List<CVehicule>();
            CVoiture v1 = new CVoiture(2015,"RJ12","Renault","Clio",true,true);
            CCamion c1 = new CCamion(2017, "RJ185", "Renault", "mmm", true, 4);
            CVoiture v2 = new CVoiture(2019, "RJ022", "Peugeot", "306", false, true);
            CCamion c2 = new CCamion(2012, "RJ185", "Renault", "mmm", true, 4);

            listVehicules.Add(c1);
            listVehicules.Add(v1);
            listVehicules.Add(c2);
            listVehicules.Add(v2);

            /*foreach(CVehicule vv in listVehicules)
            {
                CVoiture vc = vv as CVoiture;
                if(vv is CVoiture)
                {
                    (vv as CVoiture).getDescription();
                }

                if (vv is CVehicule)
                {
                    (vv as CVehicule).getDescription();
                }

                if (vv is CCamion)
                {
                    (vv as CCamion).getDescription();
                }
            }*/

            foreach (CVehicule vv in listVehicules)
            {
                vv.getDescription();
            }

        }
    }
}
