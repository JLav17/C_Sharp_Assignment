using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    internal class Question_4
    {
        // Custom Exception Class
        class InsufficientBalanceException : Exception
        {
            public InsufficientBalanceException()
                : base("Insufficient balance for this withdrawal.") { }
        }

        static void Main(string[] args)
        {
            double balance = 2000;

            try
            {
                Console.WriteLine("Current Balance: " + balance);
                Console.Write("Enter amount to withdraw: ");
                double amount = Convert.ToDouble(Console.ReadLine());

                if (amount > balance)
                {
                    throw new InsufficientBalanceException();
                }

                balance -= amount;
                Console.WriteLine("Withdrawal successful! Remaining Balance: " + balance);
            }
            catch (InsufficientBalanceException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
