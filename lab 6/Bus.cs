using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_6
{
    public class Bus : Vehicle
    {
        public Bus() : base(40, 30)
        {
            Speed = 40;
            Capacity = 30;
        }

        public override void Move()
        {
            Console.WriteLine("Bus is traveling on the route.");
        }
    }
}
