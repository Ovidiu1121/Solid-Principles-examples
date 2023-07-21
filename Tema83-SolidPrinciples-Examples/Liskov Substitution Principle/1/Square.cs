using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema83_SolidPrinciples_Examples.Liskov_Substitution_Principle._1
{
    public class Square : Rectangle
    {
        public override double Width
        {
            get { return base.Width; }
            set { base.Width = base.Height = value; }
        }

        public override double Height
        {
            get { return base.Height; }
            set { base.Width = base.Height = value; }
        }

        public Square(double side) : base(side, side)
        {
        }
    }
}
