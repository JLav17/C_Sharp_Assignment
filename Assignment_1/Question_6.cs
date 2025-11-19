using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Assignment_1
{
    internal class Question_6
    {
        static void Main(string[] args)
        {
            int[] measurements = { 2, 4, 6, 8 };
            int factor = 3;

            Console.WriteLine("Measurements After Multiplying by Factor:");

            for (int i = 0; i < measurements.Length; i++)
            {
                measurements[i] = measurements[i] * factor;
                Console.WriteLine(measurements[i]);
            }
        }
    }
}
