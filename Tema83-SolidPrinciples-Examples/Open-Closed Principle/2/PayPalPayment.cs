using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema83_SolidPrinciples_Examples.Open_Closed_Principle._2
{
    public class PayPalPayment : PaymentMethod
    {
        public override void Pay(double amount)
        {
            Console.WriteLine($"Payment of {amount}$ made via PayPal.");
        }
    }
}
