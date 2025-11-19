using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal class Question_7
    {
        // -------- Abstract Shape Class --------
        abstract class Shape
        {
            public abstract double CalculateArea();
        }

        // -------- Circle Class --------
        class Circle : Shape
        {
            public double Radius { get; set; }

            public override double CalculateArea()
            {
                return Math.PI * Radius * Radius;
            }
        }

        // -------- Rectangle Class --------
        class Rectangle : Shape
        {
            public double Length { get; set; }
            public double Width { get; set; }

            public override double CalculateArea()
            {
                return Length * Width;
            }
        }

        // -------- Main Method (Test) --------
        static void Main(string[] args)
        {
            Circle c = new Circle();
            c.Radius = 5;

            Rectangle r = new Rectangle();
            r.Length = 10;
            r.Width = 4;

            Console.WriteLine("Circle Area = " + c.CalculateArea());
            Console.WriteLine("Rectangle Area = " + r.CalculateArea());
        }
    }
}
