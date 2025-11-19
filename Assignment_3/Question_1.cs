using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal class Question_1
    {
        // Employee Class
        class Employee
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public double Salary { get; set; }

            // Method to display details
            public void DisplayDetails()
            {
                Console.WriteLine("Employee Details:");
                Console.WriteLine("Name: " + Name);
                Console.WriteLine("Age: " + Age);
                Console.WriteLine("Salary: " + Salary);
                Console.WriteLine();
            }
        }

        // Testing the class
        static void Main(string[] args)
        {
            Employee emp1 = new Employee()
            {
                Name = "Jatin",
                Age = 22,
                Salary = 30000
            };

            Employee emp2 = new Employee()
            {
                Name = "Aman",
                Age = 25,
                Salary = 45000
            };

            emp1.DisplayDetails();
            emp2.DisplayDetails();
        }
    }
}
