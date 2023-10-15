using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    public class Plant : LivingOrganism, IReproducible

    {
        public string Type { get; set; }
        public bool CanReproduce { get; set; }

        public Plant(int energy, int age, double size, string type, bool canReproduce)
            : base(energy, age, size)
        {
            Type = type;
            CanReproduce = canReproduce;
        }

    }
}
