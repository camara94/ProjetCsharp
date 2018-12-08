using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelisationObjetDesReseaux
{
    class Switch : Node
    {
        public List<Host> listHosts = new List<Host>();
        public void clearHost(string name)
        {
            listHosts.Remove(listHosts.Find(n => n.NODENAME == name));
        }

        public Switch(string switchName) : base(switchName)
        {
        }

        public void addHost(Host host)
        {
            if(listHosts.Count < this.maxPorts)
            {
                listHosts.Add(host);
            }
            else
            {
                Console.WriteLine("Vous ne pouvez dépasser " + this.maxPorts + " dans ce switch");
            }
        }

    }
}
