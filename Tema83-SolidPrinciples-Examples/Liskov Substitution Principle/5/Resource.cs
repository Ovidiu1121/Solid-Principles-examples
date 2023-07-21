using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema83_SolidPrinciples_Examples.Liskov_Substitution_Principle._5
{
    public abstract class Resource
    {
        public string Name { get; protected set; }
        public DateTime CreatedAt { get; protected set; }

        public Resource(string name)
        {
            Name = name;
            CreatedAt = DateTime.Now;
        }

        public abstract void Open();
        public abstract void Close();
    }
}
