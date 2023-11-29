using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7
{
    public class Calculator<T>
    {
        public delegate T ArithmeticOperation(T a, T b);

        public ArithmeticOperation Add { get; set; }
        public ArithmeticOperation Subtract { get; set; }
        public ArithmeticOperation Multiply { get; set; }
        public ArithmeticOperation Divide { get; set; }

        public Calculator()
        {
            Add = (a, b) => (dynamic)a + b;
            Subtract = (a, b) => (dynamic)a - b;
            Multiply = (a, b) => (dynamic)a * b;
            Divide = (a, b) => (dynamic)a / b;
        }

        public T PerformOperation(T a, T b, ArithmeticOperation operation)
        {
            if (operation == null)
            {
                throw new ArgumentNullException("operation", "Arithmetic operation is not defined.");
            }

            return operation(a, b);
        }
    }
}
