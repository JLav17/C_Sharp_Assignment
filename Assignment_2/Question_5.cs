using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class Question_5
    {
        class Student
        {
            public string Name { get; set; }
            public int RollNo { get; set; }
            public double Marks { get; set; }

            // Default constructor
            public Student()
            {
                Name = "Unknown";
                RollNo = 0;
                Marks = 0;
            }

            // Constructor with name and roll number
            public Student(string name, int rollNo)
            {
                Name = name;
                RollNo = rollNo;
                Marks = 0;
            }

            // Constructor with name, roll number, and marks
            public Student(string name, int rollNo, double marks)
            {
                Name = name;
                RollNo = rollNo;
                Marks = marks;
            }

            public void Display()
            {
                Console.WriteLine("Name: " + Name);
                Console.WriteLine("Roll No: " + RollNo);
                Console.WriteLine("Marks: " + Marks);
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Student s1 = new Student();
            Student s2 = new Student("Jatin", 101);
            Student s3 = new Student("Riya", 102, 89.5);

            s1.Display();
            s2.Display();
            s3.Display();

            Console.ReadLine();
        }
    }
}
