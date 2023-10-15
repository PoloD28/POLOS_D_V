using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    public class Animal : LivingOrganism, IReproducible, IPredator
    {
        public string Species { get; set; }
        public bool CanReproduce { get; set; }
        public bool CanHunt { get; set; }

        public Animal(int energy, int age, double size, string species, bool canReproduce, bool canHunt)
            : base(energy, age, size)
        {
            Species = species;
            CanReproduce = canReproduce;
            CanHunt = canHunt;
        }
    }
}
