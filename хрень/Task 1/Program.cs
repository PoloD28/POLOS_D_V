using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point(0, 0, "A");
            Point point2 = new Point(0, 4, "B");
            Point point3 = new Point(3, 0, "C");

            Figure triangle = new Figure(point1, point2, point3);
            triangle.CalculatePerimeter();
        }
    }
}
