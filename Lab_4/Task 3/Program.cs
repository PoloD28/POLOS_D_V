using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




using TrafficSimulation;

class Program
{
    static void Main()
    {
        Road road = new Road(10.0, 3.0, 2, 30);
        Vehicle car = new Vehicle("car", 60);
        Vehicle bus = new Vehicle("bus", 40);

        SimulateTraffic(car, road);
        SimulateTraffic(bus, road);
    }

    static void SimulateTraffic(IDriveable vehicle, Road road)
    {
        if (vehicle is Vehicle v)
        {
            v.Move(road.TrafficLevel);
        }
        else
        {
            Console.WriteLine("Unknown vehicle type");
        }
    }
}




