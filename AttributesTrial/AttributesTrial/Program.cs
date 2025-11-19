using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        Console.WriteLine(add(15, 20));

        debugMessage();

        Console.WriteLine("execution finish");
    }

    [Conditional("DEBUG")]
    static void debugMessage()
    {
        Console.WriteLine("it is DEBUG message using attribute");
    }
    static int add(int a, int b)
    {
        return (a + b);
    }

     
}
