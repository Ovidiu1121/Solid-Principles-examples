using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema83_SolidPrinciples_Examples.Liskov_Substitution_Principle._1
{
    public class Rectangle
    {
        public virtual double Width { get; set; }
        public virtual double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public virtual double Area()
        {
            return Width * Height;
        }
    }
}
