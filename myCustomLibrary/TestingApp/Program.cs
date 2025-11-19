using

namespace TestingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string testString = "   Hello, World!   ";
            string trimmedString = StringUtils.SpaceRemover(testString);
            string reversedString = StringUtils.StringReverser(trimmedString);
            Console.WriteLine($"Original String: '{testString}'");
            Console.WriteLine($"Trimmed String: '{trimmedString}'");
            Console.WriteLine($"Reversed String: '{reversedString}'");
        }
    }
}