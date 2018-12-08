using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelisationObjetDesReseaux
{
    class Link
    {

        private Port sourcePort;

        public Port SOURCEPORT
        {
            get { return sourcePort; }
            set { sourcePort = value; }
        }

        private Port targetPort;

        public Port TARGETPORT
        {
            get { return targetPort; }
            set { targetPort = value; }
        }
        private int cableLength;

        public int CABLELENGTH
        {
            get { return cableLength; }
            set { cableLength = value; }
        }

        private int cableType;

        public int CABLETYPE
        {
            get { return cableType; }
            set {
                    if(value >=0 || value <2)
                    {
                        cableType = value;
                    }
            }
        }


        public Link(Port sourcePort,Port targetPort)
        {
            this.sourcePort = sourcePort;
            this.targetPort = targetPort;
            this.cableLength = 200;
        }
    }
}
