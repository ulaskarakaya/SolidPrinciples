using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.Dependency_Inversion_Principle.Bad_Examples
{
    public class Notification
    {
        private EMail email = new EMail();
        private SMS sms = new SMS();

        public void sender()
        {

            email.sendEmail();
            sms.sendSMS();
        }

    }
}
