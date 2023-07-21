using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema83_SolidPrinciples_Examples.Liskov_Substitution_Principle._4
{
    public class Orange : IFruit
    {
        public string GetColor()
        {
            return "Orange";
        }
    }
}
