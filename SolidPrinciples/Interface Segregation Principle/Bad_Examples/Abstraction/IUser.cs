using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.Interface_Segregation_Principle.Bad_Examples.Abstraction
{
    public interface IUser
    {
        void Login();
        void GetProduct();
        void DeleteMember();
    }
}
