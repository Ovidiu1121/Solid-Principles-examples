using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema83_SolidPrinciples_Examples.Open_Closed_Principle._2
{
    internal class main
    {
        public main()
        {

            Product s = new PhysicalProduct();
            Product physicalProduct = new PhysicalProduct { Name = "T-shirt", Price = 25.99 };
            Product digitalProduct = new DigitalProduct { Name = "eBook", Price = 9.99 };
            Product membershipProduct = new MembershipProduct { Name = "Premium Membership", Price = 49.99 };

            physicalProduct.ProcessOrder();
            digitalProduct.ProcessOrder();
            membershipProduct.ProcessOrder();

            PaymentMethod creditCardPayment = new CreditCardPayment();
            PaymentMethod payPalPayment = new PayPalPayment();

            double totalAmount = physicalProduct.Price + digitalProduct.Price + membershipProduct.Price;

            creditCardPayment.Pay(totalAmount);
            payPalPayment.Pay(totalAmount);
        }
    }
}
