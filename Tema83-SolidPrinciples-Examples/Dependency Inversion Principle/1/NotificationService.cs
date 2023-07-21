using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema83_SolidPrinciples_Examples.Dependency_Inversion_Principle._1
{
    public class NotificationService
    {
        private readonly IEmailSender _emailSender;
        private readonly ISmsSender _smsSender;

        public NotificationService(IEmailSender emailSender, ISmsSender smsSender)
        {
            _emailSender = emailSender;
            _smsSender = smsSender;
        }

        public void SendNotification(string recipient, string message)
        {
            string emailSubject = "Notification";
            _emailSender.SendEmail(recipient, emailSubject, message);

            string phoneNumber = "+1234567890";
            _smsSender.SendSms(phoneNumber, message);
        }
    }
}
