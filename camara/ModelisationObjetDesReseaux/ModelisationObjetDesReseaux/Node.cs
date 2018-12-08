using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelisationObjetDesReseaux
{
    class Node
    {
        protected int idNode;

        public int IDNODE
        {
            get { return idNode; }
            set { idNode = value; }
        }

        protected String NodeName;

        public String NODENAME
        {
            get { return NodeName; }
            set { NodeName = value; }
        }

        protected int maxPorts;

        public int MAXPORTS
        {
            get { return maxPorts; }
            set { maxPorts = value; }
        }

        public List<Port> listPorts = new List<Port>();
        public List<Link> listLinks = new List<Link>();

        public Node(string nodeName)
        {
            this.NodeName = nodeName;
        }

        public void addPort(Port p)
        {
            listPorts.Add(p);
        }

        public void addLink(Link l)
        {
            listLinks.Add(l);
        }
    }
}
