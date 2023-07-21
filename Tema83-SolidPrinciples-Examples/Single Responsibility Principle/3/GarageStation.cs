using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema83_SolidPrinciples_Examples.Single_Responsibility_Principle._3
{
    public class GarageStation
    {
        IGarageUtility _garageUtil;

        public GarageStation(IGarageUtility garageUtil)
        {
            this._garageUtil = garageUtil;
        }
        public void OpenForService()
        {
            _garageUtil.OpenGate();
        }
        public void DoService()
        {
            //Check if service station is opened and then
            //finish the vehicle service
        }
        public void CloseGarage()
        {
            _garageUtil.CloseGate();
        }
    }
}
