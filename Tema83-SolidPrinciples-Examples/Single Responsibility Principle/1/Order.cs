using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema83_SolidPrinciples_Examples.Single_Responsibility_Principle._1
{
    public class Order
    {
        public int OrderId { get; set; }
        public string CustomerName { get; set; }
        public List<Product> Products { get; set; }

        public Order()
        {
            Products = new List<Product>();
        }

    }
}
