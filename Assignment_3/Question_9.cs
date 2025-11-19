using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal class Question_9
    {
        // -------- Base Class --------
        class Vehicle
        {
            public void StartEngine()
            {
                Console.WriteLine("Engine Started.");
            }

            public void StopEngine()
            {
                Console.WriteLine("Engine Stopped.");
            }
        }

        // -------- Sealed Derived Class --------
        sealed class Car : Vehicle
        {
            public void ShowCar()
            {
                Console.WriteLine("This is a Car.");
            }
        }

        static void Main(string[] args)
        {
            Car car = new Car();

            car.StartEngine();
            car.ShowCar();
            car.StopEngine();

            Console.WriteLine("\nTrying to inherit from sealed class Car will give an error.");
        }
    }
}
