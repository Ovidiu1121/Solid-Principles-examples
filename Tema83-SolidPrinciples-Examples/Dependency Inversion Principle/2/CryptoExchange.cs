using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema83_SolidPrinciples_Examples.Dependency_Inversion_Principle._2
{
    public class CryptoExchange
    {
        private readonly IPriceService _priceService;

        public CryptoExchange(IPriceService priceService)
        {
            _priceService = priceService;
        }

        public double CalculateTotalValue(string[] symbols, int[] quantities)
        {
            double totalValue = 0;

            for (int i = 0; i < symbols.Length; i++)
            {
                double price = _priceService.GetPrice(symbols[i]);
                totalValue += price * quantities[i];
            }

            return totalValue;
        }
    }
}
