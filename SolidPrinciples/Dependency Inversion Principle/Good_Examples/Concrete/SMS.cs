using SolidPrinciples.Dependency_Inversion_Principle.Good_Examples.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.Dependency_Inversion_Principle.Good_Examples.Concrete
{
    public class SMS : IMessage
    {
        public void sendMessage()
        {
            sendSMS();
        }

        private void sendSMS()
        {
            //Send sms
        }
    }
}
