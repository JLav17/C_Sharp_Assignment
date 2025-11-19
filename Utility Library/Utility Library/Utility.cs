using System;

namespace UtilityLibrary
{
    public class Utility
    {
        public static string FormatText(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return "";
            return input.ToUpper();
        }

        public static bool ValidateNumber(string input)
        {
            double temp;
            return double.TryParse(input, out temp);
        }
    }
}
