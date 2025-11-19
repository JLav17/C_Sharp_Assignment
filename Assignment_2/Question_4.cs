using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class Question_4
    {
        // Abstract Employee Class
        abstract class Employee
        {
            public string Name { get; set; }
            public int ID { get; set; }

            public abstract double CalculateSalary();
        }

        // Full-Time Employee Class
        class FullTimeEmployee : Employee
        {
            public double MonthlySalary { get; set; }

            public override double CalculateSalary()
            {
                return MonthlySalary;
            }
        }

        // Part-Time Employee Class
        class PartTimeEmployee : Employee
        {
            p
