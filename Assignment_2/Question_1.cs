using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class Question_1
    {
        // UserProfile Class
        class UserProfile
        {
            private string username;
            private string password;
            private string email;

            // Setter for Username
            public void SetUsername(string uname)
            {
                username = uname;
            }

            public string GetUsername()
            {
                return username;
            }

            // Setter for Password with Validation (min 6 characters)
            public void SetPassword(string pass)
            {
                if (pass.Length >= 6)
                    password = pass;
                else
                    Console.WriteLine("Password must be at least 6 characters!");
            }

            public string GetPassword()
            {
                return password;
            }

            // Setter for Email with Validation (@ required)
            public void SetEmail(string mail)
            {
                if (mail.Contains("@"))
                    email = mail;
                else
                    Console.WriteLine("Invalid Email! '@' missing.");
            }

            public string GetEmail()
            {
                return email;
            }
        }

        // Testing UserProfile Class
        static void Main(string[] args)
        {
            UserProfile user1 = new UserProfile();
            user1.SetUsername("john123");
            user1.SetPassword("mypwd12");
            user1.SetEmail("john@gmail.com");

            Console.WriteLine("\nUser 1 Details:");
            Console.WriteLine("Username: " + user1.GetUsername());
            Console.WriteLine("Password: " + user1.GetPassword());
            Console.WriteLine("Email: " + user1.GetEmail());

            UserProfile user2 = new UserProfile();
            user2.SetUsername("alex45");
            user2.SetPassword("123"); // invalid password
            user2.SetEmail("alexmail.com"); // invalid email

            Console.WriteLine("\nUser 2 Details:");
            Console.WriteLine("Username: " + user2.GetUsername());
            Console.WriteLine("Password: " + user2.GetPassword());
            Console.WriteLine("Email: " + user2.GetEmail());
        }
    }
}
