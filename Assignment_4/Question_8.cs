using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    internal class Question_8
    {
        // Delegate
        public delegate void BillingOperation(double amount);

        class Billing
        {
            private double discountedPrice;
            private double finalPrice;

            public void ShowTotal(double amount)
            {
                Console.WriteLine("Original Price: " + amount);
            }

            public void ApplyDiscount(double amount)
            {
                discountedPrice = amount - (amount * 0.10); // 10% discount
                Console.WriteLine("After 10% Discount: " + discountedPrice);
            }

            public void AddTax(double amount)
            {
                double taxAmount = discountedPrice * 0.18;  // 18% GST
                finalPrice = discountedPrice + taxAmount;
                Console.WriteLine("After Adding 18% GST: " + finalPrice);
            }

            public void FinalBill(double amount)
            {
                Console.WriteLine("Final Payable Amount: " + finalPrice);
            }
        }

        static void Main(string[] args)
        {
            Billing bill = new Billing();

            double price = 5000;

            BillingOperation operations;

            // Chaining delegate methods
            operations = bill.ShowTotal;
            operations += bill.ApplyDiscount;
            operations += bill.AddTax;
            operations += bill.FinalBill;

            // Execute chain
            operations(price);
        }
    }
}
