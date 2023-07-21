using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema83_SolidPrinciples_Examples.Open_Closed_Principle._2
{
    public class PhysicalProduct : Product
    {
        public override void ProcessOrder()
        {
            Console.WriteLine($"Processing order for physical product: {Name}");
            Console.WriteLine($"Price: {Price}$");
            Console.WriteLine("Packing and shipping the physical product...");
        }
    }
}
