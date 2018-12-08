using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModelisationObjetDesReseaux
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            
            Port port1 = new Port();
            Port port2 = new Port();
            Port port3 = new Port();
            Port port4 = new Port();

            Host host1 = new Host("Camara");
            host1.addPort(port1);


            Switch switch1 = new Switch("VPN1");
            switch1.addPort(port3);

            //connexion host1 au switch1
            host1.listPorts[0].addLink(switch1.listPorts[0]);

            Host host2 = new Host("Ben Salah");
            host2.addPort(port2);

            Switch switch2 = new Switch("VPN2");
            switch2.addPort(port4);

            //connexion host2 au switch2
            host2.listPorts[0].addLink(switch2.listPorts[0]);

            Console.WriteLine(host1.listPorts[0].ToString());

            //connexion host2 au switch2
            switch1.listPorts[0].addLink(switch2.listPorts[0]);
            host1.send(host2, "Bonjour Monsieur Ourir a dit qu'il ya une evalution démain");



        }

        /*public static void menu()
        {
            Console.WriteLine("==== Menu === ");
            Console.WriteLine("1- Se connecter au  réseau");
            Console.WriteLine("2- Envoyer un message");
            Console.WriteLine("3- Afficher la utilisateur connecter");
            Console.WriteLine("4- Se deconnecter ");

        }


        public static void resau()
        {
            Port port1 = new Port();
            Port port2 = new Port();
            Port port3 = new Port();
            Port port4 = new Port();

            Host host1 = new Host("Camara");
            host1.addPort(port1);


            Switch switch1 = new Switch("VPN1");
            switch1.addPort(port3);

            //connexion host1 au switch1
            host1.listPorts[0].addLink(switch1.listPorts[0]);

            Host host2 = new Host("Ben Salah");
            host2.addPort(port2);

            Switch switch2 = new Switch("VPN2");
            switch2.addPort(port4);

            //connexion host2 au switch2
            host2.listPorts[0].addLink(switch2.listPorts[0]);

            //Console.WriteLine(host1.listPorts[0].ToString());

            //connexion host2 au switch2
            switch1.listPorts[0].addLink(switch2.listPorts[0]);

            //host1.send(host2, "Bonjour Monsieur Ourir a dit qu'il ya une evalution démain");
            List<Node> listNodes = new List<Node> { switch1, switch2, host1, host2 };
            String choix = "1";
            while(choix != "5")
            {
                Console.WriteLine("Faite votre choix :");
                choix = Console.ReadLine();
                switch(choix)
                {
                    case "1":
                        {
                            Console.WriteLine("Faite votre choix :");
                            string nom = Console.ReadLine();
                            Host host = new Host(nom);
                            Port port = new Port();
                            host.addPort(port);
                            host.listPorts.Find(id => id.PORTID == port.PORTID).addLink(switch1.listPorts.Find(id => id.PORTID == port.PORTID++));
                            listNodes.Add(host);
                        }; break;
                    case "2":
                        {
                            Console.WriteLine("Identifiez-vous en donnant votre nom d'hote :");
                            String src = Console.ReadLine();
                            Console.WriteLine("Donnez le nom d'hote destinaire :");
                            String dst = Console.ReadLine();
                            Console.WriteLine("Donnez le votre message :");
                            String msg = Console.ReadLine();

                            Host h1 = (Host)listNodes.Find(n => n.NODENAME == src);
                            Host h2 = (Host)listNodes.Find(n => n.NODENAME == dst);
                            h1.send(h2, msg);
                        };break;
                }
                
            }
        }*/
    }
}
