using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Assignment_1
{
    internal class Question_8
    {
        static void Main(string[] args)
        {
            int[] grades = { 56, 78, 89, 45, 67 };

            // Sort array
            Array.Sort(grades);

            // Second smallest is at index 1
            int secondSmallest = grades[1];

            Console.WriteLine("Second Smallest Grade = " + secondSmallest);
        }
    }
}
