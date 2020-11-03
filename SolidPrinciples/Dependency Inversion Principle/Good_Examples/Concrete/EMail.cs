using SolidPrinciples.Dependency_Inversion_Principle.Good_Examples.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.Dependency_Inversion_Principle.Good_Examples.Concrete
{
    public class EMail : IMessage
    {
       
        public void sendMessage()
        {
            sendEmail();
        }
        private void sendEmail()
        {
            //Send email
        }
    }
}
