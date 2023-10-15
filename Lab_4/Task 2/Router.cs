using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class Router : Computer, IConnectable
    {
        public Router(string ipAddress, int power, string os) : base(ipAddress, power, os)
        {
        }

        public void Disconnect(Computer target)
        {
            Console.WriteLine($"Router {IPAddress} is disconnecting from {target.IPAddress}");
        }

        public void TransmitData(string data, Computer target)
        {
            Console.WriteLine($"Router {IPAddress} is sending data to {target.IPAddress}: {data}");
        }
    }
}
