using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema83_SolidPrinciples_Examples.Liskov_Substitution_Principle._2
{
    internal class debug
    {
        public debug()
        {
            Asset[] assets = new Asset[]
        {
            new Stock("AAPL", 150.50, 10),
            new Bond("US Treasury", 1000, 0.05, 5),
            new Stock("GOOGL", 2500.25, 5)
        };

            Portfolio portfolio = new Portfolio(assets);
            double totalValue = portfolio.GetTotalValue();

            Console.WriteLine($"Total portfolio value: {totalValue}");
        }

    }
}
