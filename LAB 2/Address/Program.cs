using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LAB_2
{
    class Program
    {
        public static void Main ()
        {
            Address address = new Address();
            address.Index = 02215;
            address.City = "Kyiv";
            address.House = 1;
            address.Apartment = 4;
            address.Country = "Ukraine";

            Console.WriteLine(address);
        }
    }
}
