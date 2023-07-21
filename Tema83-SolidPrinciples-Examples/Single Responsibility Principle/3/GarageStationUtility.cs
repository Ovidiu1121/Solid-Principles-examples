using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema83_SolidPrinciples_Examples.Single_Responsibility_Principle._3
{
    public class GarageStationUtility : IGarageUtility
    {
        public void OpenGate()
        {
            //Open the Garage for service
        }

        public void CloseGate()
        {
            //Close the Garage functionlity
        }
    }
}
