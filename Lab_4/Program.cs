using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
                Animal lion = new Animal(100, 5, 1.5, "Lion", true, true);
                Plant oakTree = new Plant(50, 10, 5.0, "Oak", true);
                Microorganism bacteria = new Microorganism(20, 1, 0.001, "Bacteria", true);

                Ecosystem ecosystem = new Ecosystem();
                ecosystem.SimulateInteractions(lion, oakTree);
                ecosystem.SimulateInteractions(bacteria, lion);
        }
    }
}
