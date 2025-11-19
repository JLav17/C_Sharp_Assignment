using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Assignment_1
{
    internal class Question_5
    {
        static void Main(string[] args)
        {
            int[] searchHistory = { 101, 202, 303, 404, 505 };

            Console.WriteLine("Reversed Search History:");

            for (int i = searchHistory.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(searchHistory[i]);
            }
        }
    }
}
