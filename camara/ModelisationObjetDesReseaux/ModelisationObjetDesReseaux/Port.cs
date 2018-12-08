using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelisationObjetDesReseaux
{
    class Port
    {
        private static int  n = 0;
        private int portId;

        public int PORTID
        {
            get { return this.portId; }
            set { this.portId = value; }
        }

        private int portType;

        public int PORTTYPE
        {
            get { return this.portType; }
            set {
                if(value>=0 || value < 2)
                {
                    portType = value;
                }
            }
        }

        private bool portConnected;

        public bool PORTCONNECTED
        {
            get { return this.portConnected; }
            set { this.portConnected = value; }
        }

        private int nbPorts;

        public int NBPORTS
        {
            get { return this.nbPorts; }
            set { this.nbPorts = value; }
        }

        public Port()
        {
            n++;
            this.portId = n;
            this.portConnected = false;
            this.portType = 0;
            this.nbPorts = 0;
        }

        public Port(int portType)
        {
            this.portType = portType;
        }


        public Link addLink(Port targetPort)
        {
            targetPort.PORTCONNECTED = true;
            this.PORTCONNECTED = true;
            return new Link(this, targetPort);
        }

        public override string ToString()
        {
            string str = (this.portType == 0)? "Port Normal" : "Port de cascade";
           string etat = (this.portConnected)? ", il est connecté " : ", il est deconnecté";
            return "Le port le N° : " + this.portId + ", c'est un port : " + str + etat ;
        }

    }
}
