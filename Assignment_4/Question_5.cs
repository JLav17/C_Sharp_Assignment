using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    internal class Question_5
    {
        class Car
        {
            private int speed;

            public int Speed
            {
                get { return speed; }
                set
                {
                    if (value > 180)
                    {
                        speed = 180;   // Limit speed to 180
                        Console.WriteLine("Speed limit exceeded! Setting speed to 180.");
                    }
                    else
                    {
                        speed = value;
                    }
                }
            }

            public void ShowSpeed()
            {
                Console.WriteLine("Current Speed: " + speed + " km/h");
            }
        }

        static void Main(string[] args)
        {
            Car car = new Car();

            car.Speed = 150;   // allowed
            car.ShowSpeed();

            car.Speed = 200;   // exceeds limit → set to 180
            car.ShowSpeed();
        }
    }
}
