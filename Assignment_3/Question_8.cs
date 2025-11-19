using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal class Question_8
    {
        // -------- Abstract Animal Class --------
        abstract class Animal
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public abstract void MakeSound();  // abstract method
        }

        // -------- Dog Class --------
        class Dog : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine(Name + " (Dog) says: Woof Woof!");
            }

            public void GuardHouse()
            {
                Console.WriteLine(Name + " is guarding the house.");
            }
        }

        // -------- Cat Class --------
        class Cat : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine(Name + " (Cat) says: Meow Meow!");
            }

            public void HuntMouse()
            {
                Console.WriteLine(Name + " is hunting a mouse.");
            }
        }

        // -------- Main Method (Test) --------
        static void Main(string[] args)
        {
            Dog d = new Dog()
            {
                Name = "Bruno",
                Age = 3
            };

            Cat c = new Cat()
            {
                Name = "Kitty",
                Age = 2
            };

            d.MakeSound();
            d.GuardHouse();

            Console.WriteLine();

            c.MakeSound();
            c.HuntMouse();
        }
    }
}
