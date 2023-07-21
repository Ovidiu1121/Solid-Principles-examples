using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema83_SolidPrinciples_Examples.Liskov_Substitution_Principle._5
{
    public class FileResource : Resource
    {
        public FileResource(string name) : base(name)
        {
        }

        public override void Open()
        {
            Console.WriteLine($"Opening file: {Name}");
        }

        public override void Close()
        {
            Console.WriteLine($"Closing file: {Name}");
        }
    }
}
