using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    public class Microorganism : LivingOrganism, IReproducible
    {
        public string MicrobeType { get; set; }
        public bool CanReproduce { get; set; }

        public Microorganism(int energy, int age, double size, string microbeType, bool canReproduce)
            : base(energy, age, size)
        {
            MicrobeType = microbeType;
            CanReproduce = canReproduce;
        }
    }
}
