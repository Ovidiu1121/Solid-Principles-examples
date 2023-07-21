using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema83_SolidPrinciples_Examples.Liskov_Substitution_Principle._2
{
    public class Stock : Asset
    {
        public string Ticker { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Stock(string ticker, double price, int quantity)
        {
            Ticker = ticker;
            Price = price;
            Quantity = quantity;
        }

        public override double GetValue()
        {
            return Price * Quantity;
        }
    }
}
