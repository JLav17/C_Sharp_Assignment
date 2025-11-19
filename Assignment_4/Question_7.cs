using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    internal class Question_7
    {
        // Delegate that accepts a string and returns a string
        public delegate string FormatText(string input);

        class TextFormatter
        {
            public string ToUpperCase(string input)
            {
                return input.ToUpper();
            }

            public string ToLowerCase(string input)
            {
                return input.ToLower();
            }
        }

        static void Main(string[] args)
        {
            TextFormatter tf = new TextFormatter();

            FormatText ft;   // delegate variable

            string text = "Hello World";

            // Calling uppercase method
            ft = tf.ToUpperCase;
            Console.WriteLine("Uppercase: " + ft(text));

            // Calling lowercase method
            ft = tf.ToLowerCase;
            Console.WriteLine("Lowercase: " + ft(text));
        }
    }
}
