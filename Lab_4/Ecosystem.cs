using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    public class Ecosystem
    {
        public void SimulateInteractions(LivingOrganism organism1, LivingOrganism organism2)
        {
            Console.WriteLine($"{organism1.GetType().Name} interacts with {organism2.GetType().Name}");
        }
    }
}
