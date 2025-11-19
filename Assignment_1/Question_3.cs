using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Assignment_1
{
    internal class Question_3
    {
        static void Main(string[] args)
        {
            int[] prices = { 1500, 2300, 999, 3200, 1750 };
            int largest = prices[0];

            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] > largest)
                    largest = prices[i];
            }

            Console.WriteLine("Largest Price = " + largest);
        }
    }
}
