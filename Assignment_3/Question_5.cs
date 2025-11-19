using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal class Question_5
    {
        // ----------- PART 1 of Partial Class (Properties) -----------
        public partial class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        // ----------- PART 2 of Partial Class (Methods) -----------
        public partial class Person
        {
            public void PrintFullName()
            {
                Console.WriteLine("Full Name: " + FirstName + " " + LastName);
            }
        }

        // Test the partial class
        static void Main(string[] args)
        {
            Person p = new Person();
            p.FirstName = "Jatin";
            p.LastName = "Lavania";

            p.PrintFullName();
        }
    }
}
