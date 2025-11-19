using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    internal class Question_2
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a number: ");
                int num = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("You entered: " + num);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number format.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Number too large!");
            }
            catch (Exception)
            {
                Console.WriteLine("Some error occurred.");
            }
        }
    }
}
