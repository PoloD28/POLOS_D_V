using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_6
{
    public class Car : Vehicle
    {
        public Car() : base(60, 5)
        {
            Speed = 60;
            Capacity = 5;
        }

        public override void Move()
        {
            Console.WriteLine("Car is driving on the road.");
        }
    }
}
