using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_6
{
    public class Train : Vehicle
    {
        public Train() : base(100, 200)
        {
        }
        public override void Move()
        {
            Console.WriteLine("Train is running on the tracks.");
        }
    }
}
