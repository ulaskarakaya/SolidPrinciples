using SolidPrinciples.Interface_Segregation_Principle.Bad_Examples.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.Interface_Segregation_Principle.Bad_Examples.Concrete
{
    public class Admin : IUser
    {
        public void DeleteMember()
        {
            // 
        }

        public void GetProduct()
        {
            //
        }

        public void Login()
        {
            //
        }
    }
}
