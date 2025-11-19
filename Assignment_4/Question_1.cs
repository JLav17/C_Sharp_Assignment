using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    internal class Question_1
    {
        class BankAccount
        {
            // Private field
            private double balance;

            // Property: Allows only deposit (set increases balance)
            public double Balance
            {
                get { return balance; }
                set
                {
                    if (value > 0)
                    {
                        balance += value;   // deposit logic
                    }
                }
            }

            // Withdrawal method
            public void Withdraw(double amount)
            {
                if (amount > 0 && amount <= balance)
                {
                    balance -= amount;
                    Console.WriteLine("Withdrawn: " + amount);
                }
                else
                {
                    Console.WriteLine("Invalid withdrawal amount.");
                }
            }

            // Display balance
            public void ShowBalance()
            {
                Console.WriteLine("Current Balance: " + balance);
            }
        }

        static void Main(string[] args)
        {
            BankAccount acc = new BankAccount();

            // Deposit 1000 using property
            acc.Balance = 1000;

            // Withdraw 500 using method
            acc.Withdraw(500);

            // Final balance display
            acc.ShowBalance();
        }
    }
}
