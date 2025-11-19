using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    internal class Question_2
    {
        class Student
        {
            private int age;

            public int Age
            {
                get { return age; }
                set
                {
                    if (value >= 5 && value <= 25)
                    {
                        age = value;
                    }
                    else
                    {
                        age = 18;   // default age
                        Console.WriteLine("Invalid age! Setting default age = 18");
                    }
                }
            }

            public void ShowAge()
            {
                Console.WriteLine("Student Age: " + age);
            }
        }

        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.Age = 4;   // invalid
            s1.ShowAge();

            Student s2 = new Student();
            s2.Age = 20;  // valid
            s2.ShowAge();

            Student s3 = new Student();
            s3.Age = 30;  // invalid
            s3.ShowAge();
        }
    }
}
