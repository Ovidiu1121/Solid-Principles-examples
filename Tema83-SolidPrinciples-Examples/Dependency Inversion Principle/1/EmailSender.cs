using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema83_SolidPrinciples_Examples.Dependency_Inversion_Principle._1
{
    public class EmailSender : IEmailSender
    {
        public void SendEmail(string recipient, string subject, string body)
        {
            Console.WriteLine($"Sending email to: {recipient}");
            Console.WriteLine($"Subject: {subject}");
            Console.WriteLine($"Body: {body}");
            Console.WriteLine("Email sent successfully.");
        }
    }
}
