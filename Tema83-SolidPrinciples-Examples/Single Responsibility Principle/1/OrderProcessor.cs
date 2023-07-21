using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema83_SolidPrinciples_Examples.Single_Responsibility_Principle._1
{
    public class OrderProcessor
    {
        public void ProcessOrder(Order order)
        {
            decimal totalAmount = CalculateTotalAmount(order);

            UpdateProductStock(order);

            Console.WriteLine($"Order with ID: {order.OrderId} processed successfully. Total amount: {totalAmount:C}");
        }

        private decimal CalculateTotalAmount(Order order)
        {
            decimal total = 0;

            foreach (var product in order.Products)
            {
                total += product.Price*product.Stock;
            }

            return total;
        }

        private void UpdateProductStock(Order order)
        {
            foreach (var product in order.Products)
            {
                product.Stock -= 1; 
            }
        }
    }
}
