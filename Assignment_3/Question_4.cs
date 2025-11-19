using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal class Question_4
    {
        // Static Logger Class
        public static class Logger
        {
            public static void LogMessage(string message)
            {
                Console.WriteLine("[LOG] " + message);
            }
        }

        // Testing Logger in Main
        static void Main(string[] args)
        {
            Logger.LogMessage("Application started.");
            Logger.LogMessage("User logged in successfully.");
            Logger.LogMessage("This is a test log message.");
        }
    }
}
