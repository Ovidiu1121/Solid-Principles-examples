using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema83_SolidPrinciples_Examples.Interface_Segregation_Principle._3
{
    public class OnlineOrder : IOrder, IOnlineOrder
    {
        public void AddToCart()
        {
            //Do Add to Cart
        }

        public void CCProcess()
        {
            //process through credit card
        }
    }
}
