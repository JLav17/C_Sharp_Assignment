using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class Question_2
    {
        // Base Class
        class Vehicle
        {
            public string Make { get; set; }
            public string Model { get; set; }
            public int Year { get; set; }
        }

        // Derived Class: Truck
        class Truck : Vehicle
        {
            public void DisplayDetails()
            {
                Console.WriteLine("Truck Details:");
                Console.WriteLine("Make: " + Make);
                Console.WriteLine("Model: " + Model);
                Console.WriteLine("Year: " + Year);
                Console.WriteLine();
            }
        }

        // Derived Class: Bus
        class Bus : Vehicle
        {
            public void DisplayDetails()
            {
                Console.WriteLine("Bus Details:");
                Console.WriteLine("Make: " + Make);
                Console.WriteLine("Model: " + Model);
                Console.WriteLine("Year: " + Year);
                Console.WriteLine();
            }
        }

        // Main Method to Test
        static void Main(string[] args)
        {
            Truck truck1 = new Truck()
            {
                Make = "Tata",
                Model = "Ultra",
                Year = 2020
            };

            Bus bus1 = new Bus()
            {
                Make = "Volvo",
                Model = "9400",
                Year = 2022
            };

            truck1.DisplayDetails();
            bus1.DisplayDetails();
        }
    }
}
