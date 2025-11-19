using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    internal class Question_5
    {
        // Custom exception class
        class InvalidMarksException : Exception
        {
            public InvalidMarksException()
                : base("Marks must be between 0 and 100.") { }
        }

        class Student
        {
            private int marks;

            public int Marks
            {
                get { return marks; }
                set
                {
                    if (value < 0 || value > 100)
                        throw new InvalidMarksException();

                    marks = value;
                }
            }
        }

        static void Main(string[] args)
        {
            Student s = new Student();

            try
            {
                Console.Write("Enter student marks: ");
                int m = Convert.ToInt32(Console.ReadLine());

                s.Marks = m;    // may throw exception

                Console.WriteLine("Marks saved successfully: " + s.Marks);
            }
            catch (InvalidMarksException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter valid numeric marks.");
            }
        }
    }
}
