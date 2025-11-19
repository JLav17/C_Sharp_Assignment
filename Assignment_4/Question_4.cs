using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    internal class Question_4
    {
        class Product
        {
            public double Price { get; set; }
            public double Discount { get; set; }

            public double GetFinalPrice()
            {
                return Price - (Price * Discount / 100);
            }
        }

        static void Main(string[] args)
        {
            Product p = new Product()
            {
                Price = 2000,
                Discount = 10
            };

            double finalPrice = p.GetFinalPrice();

            Console.WriteLine("Original Price: " + p.Price);
            Console.WriteLine("Discount: " + p.Discount + "%");
            Console.WriteLine("Final Price: " + finalPrice);
        }
    }
}
