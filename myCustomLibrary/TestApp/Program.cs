using myCustomLibrary;

using System;

namespace TestingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string testString = "   Hello, World!   ";
            string trimmedString = StringUtils.spaceRemover(testString);
            string reversedString = StringUtils.stringReverse(trimmedString);
            Console.WriteLine($"Original String: '{testString}'");
            Console.WriteLine($"Trimmed String: '{trimmedString}'");
            Console.WriteLine($"Reversed String: '{reversedString}'");
        }
    }
}