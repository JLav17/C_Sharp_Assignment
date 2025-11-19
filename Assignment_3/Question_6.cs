using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal class Question_6
    {
        // ----------- PART 1 of Partial Employee (Properties) -----------
        public partial class Employee
        {
            public string Name { get; set; }
            public int EmployeeID { get; set; }
            public double BaseSalary { get; set; }
            public double Bonus { get; set; }
        }

        // ----------- PART 2 of Partial Employee (Methods) -----------
        public partial class Employee
        {
            public double CalculateTotalSalary()
            {
                return BaseSalary + Bonus;
            }

            public void DisplayDetails()
            {
                Console.WriteLine("Employee Name: " + Name);
                Console.WriteLine("Employee ID: " + EmployeeID);
                Console.WriteLine("Base Salary: " + BaseSalary);
                Console.WriteLine("Bonus: " + Bonus);
                Console.WriteLine("Total Salary: " + CalculateTotalSalary());
            }
        }

        // ----------- Main Method (Test) -----------
        static void Main(string[] args)
        {
            Employee emp = new Employee()
            {
                Name = "Jatin",
                EmployeeID = 101,
                BaseSalary = 30000,
                Bonus = 5000
            };

            emp.DisplayDetails();
        }
    }
}
