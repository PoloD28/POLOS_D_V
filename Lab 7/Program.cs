using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7
{
    class Program
    {
        static void Main()
        {

            Calculator<int> intCalculator = new Calculator<int>();
            int a = 10;
            int b = 5;

            Console.WriteLine($"Addition: {intCalculator.PerformOperation(a, b, intCalculator.Add)}");
            Console.WriteLine($"Subtraction: {intCalculator.PerformOperation(a, b, intCalculator.Subtract)}");
            Console.WriteLine($"Multiplication: {intCalculator.PerformOperation(a, b, intCalculator.Multiply)}");
            Console.WriteLine($"Division: {intCalculator.PerformOperation(a, b, intCalculator.Divide)}");


            Calculator<double> doubleCalculator = new Calculator<double>();
            double x = 10.5;
            double y = 2.5;

            Console.WriteLine($"Addition: {doubleCalculator.PerformOperation(x, y, doubleCalculator.Add)}");
            Console.WriteLine($"Subtraction: {doubleCalculator.PerformOperation(x, y, doubleCalculator.Subtract)}");
            Console.WriteLine($"Multiplication: {doubleCalculator.PerformOperation(x, y, doubleCalculator.Multiply)}");
            Console.WriteLine($"Division: {doubleCalculator.PerformOperation(x, y, doubleCalculator.Divide)}");
        }
    }
}
