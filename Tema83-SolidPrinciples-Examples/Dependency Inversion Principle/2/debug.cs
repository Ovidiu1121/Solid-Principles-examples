using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema83_SolidPrinciples_Examples.Dependency_Inversion_Principle._2
{
    internal class debug
    {
        public debug()
        {
            IPriceService externalPriceService = new ExternalPriceService();
            CryptoExchange exchange = new CryptoExchange(externalPriceService);

            string[] symbols = { "BTC", "ETH" };
            int[] quantities = { 2, 5 };
            double totalValue = exchange.CalculateTotalValue(symbols, quantities);

            Console.WriteLine($"Total portfolio value using external price service: {totalValue}");

            IPriceService mockPriceService = new MockPriceService();
            CryptoExchange exchangeForTesting = new CryptoExchange(mockPriceService);

            double totalValueForTesting = exchangeForTesting.CalculateTotalValue(symbols, quantities);

            Console.WriteLine($"Total portfolio value using mock price service: {totalValueForTesting}");
        }

    }
}
