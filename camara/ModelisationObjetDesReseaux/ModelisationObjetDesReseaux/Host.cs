using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelisationObjetDesReseaux
{
    class Host:Node
    {
        private static int n = 0;
        private int physicalAdress;

        public int PHYSICALADRESS
        {
            get { return physicalAdress; }
            
        }

        public Host(string hostName):base(hostName)
        {
            n++;
            this.physicalAdress = n;
        }

        public bool send(Host host,string msg)
        {
            bool val = false;
            int i = host.listPorts.Count;
            for(int j = 0; j < i; j++)
            {
                if (host.listPorts[j].PORTCONNECTED && this.listPorts[j].PORTCONNECTED)
                {
                    val = true;
                }
            }

            if(val)
            {
                Console.WriteLine("||===\n Rource : " + this.NodeName + "\nAdresse MAC Rource : "+ this.physicalAdress + "\nMessage : " + msg + "\nDestinataire : " + host.NODENAME + "\nAdresse MAC Destinataire : " + host.physicalAdress + "\n===||");
            }

            return val;
        }

        public Port getPort(int id)
        {
            return listPorts.Find(n => n.PORTID == id);
        }

    }
}
