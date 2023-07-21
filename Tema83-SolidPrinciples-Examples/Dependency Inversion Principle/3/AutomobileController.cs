using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema83_SolidPrinciples_Examples.Dependency_Inversion_Principle._3
{
    public class AutomobileController
    {
        IAutomobile m_Automobile;

        public AutomobileController(IAutomobile automobile)
        {
            this.m_Automobile = automobile;
        }

        public void Ignition()
        {
            m_Automobile.Ignition();
        }

        public void Stop()
        {
            m_Automobile.Stop();
        }
    }
}
