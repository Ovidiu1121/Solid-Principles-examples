using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema83_SolidPrinciples_Examples.Dependency_Inversion_Principle._3
{
    public class Jeep : IAutomobile
    {
        #region IAutomobile Members
        public void Ignition()
        {
            Console.WriteLine("Jeep start");
        }

        public void Stop()
        {
            Console.WriteLine("Jeep stopped.");
        }
        #endregion
    }
}
