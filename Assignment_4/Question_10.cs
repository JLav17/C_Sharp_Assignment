using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    internal class Question_10
    {
        // Delegate that accepts a string message
        public delegate void Notifier(string message);

        class NotificationService
        {
            public void SendEmail(string message)
            {
                Console.WriteLine("Email Sent: " + message);
            }

            public void SendSMS(string message)
            {
                Console.WriteLine("SMS Sent: " + message);
            }
        }

        static void Main(string[] args)
        {
            NotificationService notify = new NotificationService();

            Notifier notifier;

            // Delegate chaining
            notifier = notify.SendEmail;
            notifier += notify.SendSMS;

            string msg = "Assignment Submitted Successfully";

            // Call both notifications
            notifier(msg);
        }
    }
}
