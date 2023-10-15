using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace TrafficSimulation
{
    public class Road
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public int NumberOfLanes { get; set; }
        public int TrafficLevel { get; set; }

        public Road(double length, double width, int numberOfLanes, int trafficLevel)
        {
            Length = length;
            Width = width;
            NumberOfLanes = numberOfLanes;
            TrafficLevel = trafficLevel;
        }
    }
}

