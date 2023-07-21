using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema83_SolidPrinciples_Examples.Dependency_Inversion_Principle._2
{
    public class ExternalPriceService : IPriceService
    {
        public double GetPrice(string symbol)
        {
            // Simulăm obținerea prețurilor de pe un API extern
            // Aici ar fi logica reală de apelare a API-ului pentru prețuri
            // În exemplul acesta, vom returna doar valori simulate pentru scopuri de ilustrare
            if (symbol == "BTC")
            {
                return 45000.50;
            }
            else if (symbol == "ETH")
            {
                return 3000.75;
            }
            else
            {
                throw new ArgumentException("Unsupported cryptocurrency symbol.");
            }
        }
    }
}
