using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    internal class Question_3
    {
        class Employee
        {
            private double basicSalary;

            // Setter method to set basic salary
            public void SetBasicSalary(double salary)
            {
                basicSalary = salary;
            }

            // Read-only property: TotalSalary
            public double TotalSalary
            {
                get
                {
                    return basicSalary + (basicSalary * 0.20); // adding 20% bonus
                }
            }
        }

        static void Main(string[] args)
        {
            Employee emp = new Employee();

            emp.SetBasicSalary(30000);  // setting basic salary

            Console.WriteLine("Total Salary (with 20% bonus): " + emp.TotalSalary);
        }
    }
}
