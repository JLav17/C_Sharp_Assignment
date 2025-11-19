using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal class Question_10
    {
        class BankAccount
        {
            public int AccountNumber { get; set; }
            public double Balance { get; set; }

            public void Deposit(double amount)
            {
                Balance += amount;
                Console.WriteLine("Deposited: " + amount);
            }

            public void DisplayBalance()
            {
                Console.WriteLine("Account Number: " + AccountNumber);
                Console.WriteLine("Balance: " + Balance);
            }
        }

        sealed class SavingsAccount : BankAccount
        {
            public double InterestRate { get; set; }

            public void CalculateInterest()
            {
                double interest = (Balance * InterestRate) / 100;
                Console.WriteLine("Interest Earned: " + interest);
            }
        }
        static void Main(string[] args)
        {
            SavingsAccount sa = new SavingsAccount()
            {
                AccountNumber = 12345,
                Balance = 5000,
                InterestRate = 5
            };

            sa.DisplayBalance();
            sa.CalculateInterest();
        }
    }
}
