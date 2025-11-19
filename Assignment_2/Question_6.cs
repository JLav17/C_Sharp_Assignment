using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class Question_6
    {
        // Product class
        class Product
        {
            // Auto-implemented properties with validation
            private int productID;
            private string productName;
            private double price;
            private int quantity;

            public int ProductID
            {
                get { return productID; }
                set { productID = value; }
            }

            public string ProductName
            {
                get { return productName; }
                set { productName = value; }
            }

            public double Price
            {
                get { return price; }
                set
                {
                    if (value >= 0)
                        price = value;
                    else
                        Console.WriteLine("Price cannot be negative!");
                }
            }

            public int Quantity
            {
                get { return quantity; }
                set
                {
                    if (value >= 0)
                        quantity = value;
                    else
                        Console.WriteLine("Quantity cannot be negative!");
                }
            }

            // Method to print product details
            public void DisplayProduct()
            {
                Console.WriteLine("Product ID: " + ProductID);
                Console.WriteLine("Product Name: " + ProductName);
                Console.WriteLine("Price: " + Price);
                Console.WriteLine("Quantity: " + Quantity);
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            // Valid product
            Product p1 = new Product();
            p1.ProductID = 101;
            p1.ProductName = "Keyboard";
            p1.Price = 799;
            p1.Quantity = 10;

            Console.WriteLine("Valid Product Details:");
            p1.DisplayProduct();

            // Invalid product input test
            Product p2 = new Product();
            p2.ProductID = 102;
            p2.ProductName = "Mouse";
            p2.Price = -500;     // invalid
            p2.Quantity = -2;    // invalid

            Console.WriteLine("Invalid Product Details:");
            p2.DisplayProduct();
        }
    }
}
