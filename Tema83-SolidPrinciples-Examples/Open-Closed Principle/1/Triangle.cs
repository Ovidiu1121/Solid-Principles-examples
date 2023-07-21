using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema83_SolidPrinciples_Examples.Open_Closed_Principle._1
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
            Console.WriteLine($"Triunghi cu baza: {Base} si inaltime: {Height}");
        }
    }
}
