using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace TrafficSimulation
{
    public class Vehicle : IDriveable
    {
        public string Type { get; set; }
        public double Speed { get; set; } 

        public Vehicle(string type, double speed) 
        {
            Type = type;
            Speed = speed;
        }

        public void Move(double speed)
        {
            Console.WriteLine($"The {Type} is moving at a speed of {speed} km/h.");
        }

        public void Stop()
        {
            Console.WriteLine($"The {Type} has stopped.");
        }
    }
}

