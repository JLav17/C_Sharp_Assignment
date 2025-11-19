using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    internal class Question_3
    {
        // Custom Exception Class
        class NegativeSalaryException : Exception
        {
            public NegativeSalaryException() : base("Salary cannot be negative.") { }
        }

        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter salary: ");
                double salary = Convert.ToDouble(Console.ReadLine());

                if (salary < 0)
                {
                    throw new NegativeSalaryException();
                }

                Console.WriteLine("Salary entered: " + salary);
            }
            catch (NegativeSalaryException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
