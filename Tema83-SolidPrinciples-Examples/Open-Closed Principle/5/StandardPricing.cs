using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema83_SolidPrinciples_Examples.Open_Closed_Principle._5
{
    public class StandardPricing : IPricingStrategy
    {
        public decimal CalculatePrice(Product product)
        {
            return product.Price;
        }
    }
}
