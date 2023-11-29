using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace lab_6
{
    class Program
    {
        static void Main()
        {
            Car car = new Car();
            Bus bus = new Bus();
            Train train = new Train();

            Route route = new Route("City A", "City B");

            TransportNetwork transportNetwork = new TransportNetwork();

            transportNetwork.CalculateOptimalRoute(car, route);
            car.BoardPassengers(3);
            car.Move();
            car.DisembarkPassengers(2);

            transportNetwork.CalculateOptimalRoute(bus, route);
            bus.BoardPassengers(20);
            bus.Move();
            bus.DisembarkPassengers(15);

            transportNetwork.CalculateOptimalRoute(train, route);
            train.BoardPassengers(150);
            train.Move();
            train.DisembarkPassengers(100);
        }
    }
}
