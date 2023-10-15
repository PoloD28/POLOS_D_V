using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    public class LivingOrganism
    {
        public int Energy { get; set; }
        public int Age { get; set; }
        public double Size { get; set; }

        public LivingOrganism(int energy, int age, double size)
        {
            Energy = energy;
            Age = age;
            Size = size;
        }
    }
}
