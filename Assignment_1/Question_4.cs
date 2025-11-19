using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Assignment_1
{
    internal class Question_4
    {
        static void Main(string[] args)
        {
            int[] participantCodes = { 102, 215, 324, 453, 536 };
            int evenCount = 0;
            int oddCount = 0;

            for (int i = 0; i < participantCodes.Length; i++)
            {
                if (participantCodes[i] % 2 == 0)
                    evenCount++;
                else
                    oddCount++;
            }

            Console.WriteLine("Number of Males (Even): " + evenCount);
            Console.WriteLine("Number of Females (Odd): " + oddCount);
        }
    }
}
