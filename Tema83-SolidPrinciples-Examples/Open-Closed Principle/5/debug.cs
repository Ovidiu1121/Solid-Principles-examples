using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema83_SolidPrinciples_Examples.Open_Closed_Principle._5
{
    public class debug
    {
        public debug()
        {
            Product product1 = new Product("Laptop", 1500);
            Product product2 = new Product("Smartphone", 800);
            Product product3 = new Product("Headphones", 100);

            ShoppingCart cart1 = new ShoppingCart(new StandardPricing());
            cart1.AddProduct(product1);
            cart1.AddProduct(product2);

            ShoppingCart cart2 = new ShoppingCart(new DiscountPricing());
            cart2.AddProduct(product2);
            cart2.AddProduct(product3);

            ShoppingCart cart3 = new ShoppingCart(new SpecialDiscountPricing());
            cart3.AddProduct(product1);
            cart3.AddProduct(product3);

            Console.WriteLine($"Cart 1 total price: {cart1.CalculateTotalPrice()}$");
            Console.WriteLine($"Cart 2 total price: {cart2.CalculateTotalPrice()}$");
            Console.WriteLine($"Cart 3 total price: {cart3.CalculateTotalPrice()}$");
        }
    }
}
