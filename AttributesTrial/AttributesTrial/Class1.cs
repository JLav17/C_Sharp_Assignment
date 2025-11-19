using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributesTrial
{
    internal class Class1
    {
        static void Main(string [] args)
        {
            Console.WriteLine(addNumbers(4,3,52,54,6));
            Console.WriteLine(addTwoNumbers(3,56));

        }

        [Obsolete("this addTwoNumbers() method is deprecated, use addNumbers() that accepts any number of arguments")]
        static int addTwoNumbers (int a ,int b)
        {
            return a + b;
        }
            
        static int addNumbers(params int[] nums)
        {
            int sum = 0;
            foreach (int num in nums)
            {
                sum += num;
            }
            return sum;
        }

    }
}
