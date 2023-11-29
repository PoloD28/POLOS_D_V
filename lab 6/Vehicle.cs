using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_6
{
    public abstract class Vehicle
    {
        public int Speed { get; set; }
        public int Capacity { get; set; }
        public int CurrentPassengers { get; private set; }

        public Vehicle(int speed, int capacity)
        {
            Speed = speed;
            Capacity = capacity;
            CurrentPassengers = 0;
        }

        public abstract void Move();

        public void BoardPassengers(int passengers)
        {
            if (passengers + CurrentPassengers <= Capacity)
            {
                CurrentPassengers += passengers;
                Console.WriteLine($"{passengers} passengers boarded the {GetType().Name}.");
            }
            else
            {
                Console.WriteLine($"Cannot board {passengers} passengers, the {GetType().Name} is full.");
            }
        }

        public void DisembarkPassengers(int passengers)
        {
            if (passengers <= CurrentPassengers)
            {
                CurrentPassengers -= passengers;
                Console.WriteLine($"{passengers} passengers disembarked from the {GetType().Name}.");
            }
            else
            {
                Console.WriteLine($"Cannot disembark {passengers} passengers, there are not enough passengers on the {GetType().Name}.");
            }
        }
    }
}
