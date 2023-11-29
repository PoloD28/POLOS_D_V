using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_2.Employee
{
    class Program2
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Semenov", "Max");
            employee.CalculateSalaryAndTax(Position.designer, 10);
            employee.PrintSalaryWithTax();
            Console.Write(employee);
        }
    }
}
