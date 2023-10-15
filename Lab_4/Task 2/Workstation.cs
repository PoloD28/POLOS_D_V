using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class Workstation : Computer, IConnectable
    {
        public Workstation(string ipAddress, int power, string os) : base(ipAddress, power, os)
        {
        }

        public void Disconnect(Computer target)
        {
            Console.WriteLine($"Workstation {IPAddress} is disconnecting from {target.IPAddress}");
        }

        public void TransmitData(string data, Computer target)
        {
            Console.WriteLine($"Workstation {IPAddress} is sending data to {target.IPAddress}: {data}");
        }
    }
}
