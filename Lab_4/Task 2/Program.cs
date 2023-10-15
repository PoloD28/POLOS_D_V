using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main()
        {
            Network network = new Network();

            Server server1 = new Server("192.168.1.1", 1000, "Windows Server");
            Server server2 = new Server("192.168.1.2", 1200, "Linux Server");
            Workstation workstation1 = new Workstation("192.168.1.3", 800, "Windows 10");
            Workstation workstation2 = new Workstation("192.168.1.4", 700, "Ubuntu");
            Router router1 = new Router("192.168.1.5", 300, "Embedded Router");

            network.AddComputer(server1);
            network.AddComputer(server2);
            network.AddComputer(workstation1);
            network.AddComputer(workstation2);
            network.AddComputer(router1);

            network.SimulateNetwork();
        }
    }
}
