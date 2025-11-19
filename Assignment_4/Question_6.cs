using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    internal class Question_6
    {
        // Delegate declaration
        public delegate double Operation(double a, double b);

        class Calculator
        {
            public double Add(double a, double b)
            {
                return a + b;
            }

            public double Subtract(double a, double b)
            {
                return a - b;
            }
        }

        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            // Delegate pointing to Add method
            Operation op = calc.Add;
            Console.WriteLine("Addition = " + op(num1, num2));

            // Delegate pointing to Subtract method
            op = calc.Subtract;
            Console.WriteLine("Subtraction = " + op(num1, num2));
        }
    }
}
