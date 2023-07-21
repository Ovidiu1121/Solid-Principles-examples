using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema83_SolidPrinciples_Examples.Open_Closed_Principle._2
{
    public abstract class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public abstract void ProcessOrder();
    }
}
