using SolidPrinciples.Dependency_Inversion_Principle.Good_Examples.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.Dependency_Inversion_Principle.Good_Examples.Concrete
{
    public class Notification
    {
        private List<IMessage> messages;

        public Notification(List<IMessage> messages)
        {
            this.messages = messages;
        }

        public void sender()
        {
            foreach (IMessage message in messages)
            {
                message.sendMessage();
            }
        }
    }
}
