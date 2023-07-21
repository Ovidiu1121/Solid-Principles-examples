using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema83_SolidPrinciples_Examples.Dependency_Inversion_Principle._2
{
    public class MockPriceService : IPriceService
    {
        public double GetPrice(string symbol)
        {
            // Simulăm prețuri pentru teste
            if (symbol == "BTC")
            {
                return 46000.25;
            }
            else if (symbol == "ETH")
            {
                return 3200.10;
            }
            else
            {
                throw new ArgumentException("Unsupported cryptocurrency symbol.");
            }
        }
    }
}
