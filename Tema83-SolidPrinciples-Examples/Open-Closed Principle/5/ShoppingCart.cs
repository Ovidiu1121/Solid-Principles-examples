using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema83_SolidPrinciples_Examples.Open_Closed_Principle._5
{
    public class ShoppingCart
    {
        private readonly IPricingStrategy _pricingStrategy;
        private readonly List<Product> _products;

        public ShoppingCart(IPricingStrategy pricingStrategy)
        {
            _pricingStrategy = pricingStrategy;
            _products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public decimal CalculateTotalPrice()
        {
            decimal totalPrice = 0;
            foreach (var product in _products)
            {
                totalPrice += _pricingStrategy.CalculatePrice(product);
            }
            return totalPrice;
        }
    }
}
