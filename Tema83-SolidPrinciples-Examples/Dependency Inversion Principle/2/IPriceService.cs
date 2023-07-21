using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema83_SolidPrinciples_Examples.Dependency_Inversion_Principle._2
{
    public interface IPriceService
    {
        double GetPrice(string symbol);
    }
}
