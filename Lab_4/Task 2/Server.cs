using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class Server : Computer, IConnectable
    {
        public Server(string ipAddress, int power, string os) : base(ipAddress, power, os)
        {
        }

        public void Disconnect(Computer target)
        {
            Console.WriteLine($"Server {IPAddress} is disconnecting from {target.IPAddress}");
        }

        public void TransmitData(string data, Computer target)
        {
            Console.WriteLine($"Server {IPAddress} is sending data to {target.IPAddress}: {data}");
        }
    }
}
