using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal class Question_2
    {
        // BankAccount Class
        class BankAccount
        {
            public int AccountNumber { get; set; }
            public string AccountHolderName { get; set; }
            public double Balance { get; private set; }

            // Deposit method
            public void Deposit(double amount)
            {
                if (amount > 0)
                {
                    Balance += amount;
                    Console.WriteLine("Deposited: " + amount);
                }
                else
                {
                    Console.WriteLine("Invalid deposit amount.");
                }
            }

            // Withdraw method
            public void Withdraw(double amount)
            {
                if (amount <= Balance && amount > 0)
                {
                    Balance -= amount;
                    Console.WriteLine("Withdrawn: " + amount);
                }
                else
                {
                    Console.WriteLine("Insufficient balance or invalid amount.");
                }
            }

            // Display account details
            public void DisplayAccountDetails()
            {
                Console.WriteLine("\nAccount Details:");
                Console.WriteLine("Account Number: " + AccountNumber);
                Console.WriteLine("Account Holder: " + AccountHolderName);
                Console.WriteLine("Balance: " + Balance);
            }
        }

        // Testing the class
        static void Main(string[] args)
        {
            BankAccount acc = new BankAccount()
            {
                AccountNumber = 12345,
                AccountHolderName = "Jatin"
            };

            acc.Deposit(5000);
            acc.Withdraw(1200);
            acc.DisplayAccountDetails();
        }
    }
}
