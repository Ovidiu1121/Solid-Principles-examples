using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema83_SolidPrinciples_Examples.Interface_Segregation_Principle._1
{
    public class Bird : IAnimal, IFlyable
    {
        public void Eat()
        {
            Console.WriteLine("Bird is eating.");
        }

        public void Sleep()
        {
            Console.WriteLine("Bird is sleeping.");
        }

        public void Fly()
        {
            Console.WriteLine("Bird is flying.");
        }
    }
}
