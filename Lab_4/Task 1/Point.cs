using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Point
    {
        public double X { get; }
        public double Y { get; }
        public string Name { get; }

        public Point(double x, double y, string name)
        {
            X = x;
            Y = y;
            Name = name;
        }
    }
}
