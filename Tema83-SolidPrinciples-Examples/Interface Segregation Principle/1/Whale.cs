using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema83_SolidPrinciples_Examples.Interface_Segregation_Principle._1
{
    public class Whale : IAnimal, ISwimmable
    {
        public void Eat()
        {
            Console.WriteLine("Whale is eating.");
        }

        public void Sleep()
        {
            Console.WriteLine("Whale is sleeping.");
        }

        public void Swim()
        {
            Console.WriteLine("Whale is swimming.");
        }
    }
}
