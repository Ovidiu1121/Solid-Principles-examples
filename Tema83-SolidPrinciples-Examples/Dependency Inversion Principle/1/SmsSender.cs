using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema83_SolidPrinciples_Examples.Dependency_Inversion_Principle._1
{
    public class SmsSender : ISmsSender
    {
        public void SendSms(string phoneNumber, string message)
        {
            Console.WriteLine($"Sending SMS to: {phoneNumber}");
            Console.WriteLine($"Message: {message}");
            Console.WriteLine("SMS sent successfully.");
        }
    }
}
