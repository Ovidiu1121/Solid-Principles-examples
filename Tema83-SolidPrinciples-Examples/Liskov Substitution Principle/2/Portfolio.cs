using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema83_SolidPrinciples_Examples.Liskov_Substitution_Principle._2
{
    public class Portfolio
    {
        public Asset[] Assets { get; set; }

        public Portfolio(Asset[] assets)
        {
            Assets = assets;
        }

        public double GetTotalValue()
        {
            double totalValue = 0;
            foreach (Asset asset in Assets)
            {
                totalValue += asset.GetValue();
            }
            return totalValue;
        }
    }
}
