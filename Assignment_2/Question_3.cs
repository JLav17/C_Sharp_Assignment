using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class Question_3
    {
        // Calculator class with overloaded Add() methods
        class Calculator
        {
            // Add two integers
            public int Add(int a, int b)
            {
                return a + b;
            }

            // Add three integers
            public int Add(int a, int b, int c)
            {
                return a + b + c;
            }

            // Add two floats
            public float Add(float a, float b)
            {
                return a + b;
            }

            // Add two doubles
            public double Add(double a, double b)
            {
                return a + b;
            }
        }

        // Testing all variations
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            Console.WriteLine("Add(int, int): " + calc.Add(10, 20));
            Console.WriteLine("Add(int, int, int): " + calc.Add(5, 10, 15));
            Console.WriteLine("Add(float, float): " + calc.Add(2.5f, 3.5f));
            Console.WriteLine("Add(double, double): " + calc.Add(4.5, 6.7));
        }
    }
}
