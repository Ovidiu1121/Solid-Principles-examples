using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema83_SolidPrinciples_Examples.Liskov_Substitution_Principle._3
{
    public class Triangle : Shape
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public Triangle(double @base, double height)
        {
            Base = @base;
            Height = height;
        }

        public override double Area()
        {
            return 0.5 * Base * Height;
        }

        public override void Display()
        {
            Console.WriteLine($"Triangle with base: {Base} and height: {Height}");
        }
    }
}
