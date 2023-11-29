using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_6
{
    public class Human
    {
        public int Speed { get; set; }
        public void Move()
        {
            Console.WriteLine("Human is moving on foot.");
        }
    }
}
