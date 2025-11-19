using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal class Question_3
    {
        // Static Utility Class
        public static class MathHelper
        {
            public static double CalculateAverage(int[] numbers)
            {
                int sum = 0;

                for (int i = 0; i < numbers.Length; i++)
                {
                    sum += numbers[i];
                }

                return (double)sum / numbers.Length;
            }
        }

        // Test the method
        static void Main(string[] args)
        {
            int[] data = { 10, 20, 30, 40, 50 };

            double avg = MathHelper.CalculateAverage(data);

            Console.WriteLine("Average = " + avg);
        }
    }
}
