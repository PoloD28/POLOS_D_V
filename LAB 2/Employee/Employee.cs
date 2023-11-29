using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_2.Employee
{
    public enum Position
    {
        manager,
        developer,
        designer
    }

    public class Employee
    {
        private string lastName;
        private string firstName;
        private Position position;

        private double salaryWithTax;
        private double baseSalary;
        private double tax;

        public Employee(string lastName, string firstName)
        {
            this.lastName = lastName;
            this.firstName = firstName;

        }

        public void CalculateSalaryAndTax(Position position, int experience)
        {
            this.position = position;

            switch (position)
            {
                case Position.manager:
                    baseSalary = 50000; break;
                case Position.developer:
                    baseSalary = 60000; break;
                case Position.designer:
                    baseSalary = 55000; break;
            }

            if (experience >= 0)
            {
                tax = baseSalary * 0.15;
            }
            else
            {
                tax = baseSalary * 0.20;
            }

            salaryWithTax = baseSalary - tax;
        }

        public void PrintSalaryWithTax()
        {
            Console.WriteLine("Information about the employee:");
            Console.WriteLine($"LastName: {lastName}");
            Console.WriteLine($"FirstName: {firstName}");
            Console.WriteLine($"Position: {position}");
            Console.WriteLine($"BaseSalary: {baseSalary}");
            Console.WriteLine($"Tax: {tax}");
            Console.WriteLine($"Final: {salaryWithTax}");
        }
    }
}
