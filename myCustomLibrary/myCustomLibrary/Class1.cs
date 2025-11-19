using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myCustomLibrary
{
    public class StringUtils
    {
        public static string spaceRemover(string input)
        {
            if (input == null) return null;
            return input.TrimStart().TrimEnd();
        }

        public static string stringReverse(string input)
        {
            char[] charArray = input.ToCharArray();  // Convert string to character array
            Array.Reverse(charArray);              // Reverse the array
            string reversed = new string(charArray);
            return reversed;
        }

    }
}
