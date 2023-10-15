using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class Computer
    {
        public string IPAddress { get; set; }
        public int Power { get; set; }
        public string OS { get; set; }

        public Computer(string ipAddress, int power, string os)
        {
            IPAddress = ipAddress;
            Power = power;
            OS = os;
        }
    }
}
