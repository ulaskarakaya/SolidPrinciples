using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.Interface_Segregation_Principle.Good_Examples.Abstraction
{
    public interface IAdmin
    {
        void Login();
        void GetProduct();
        void DeleteMember();
    }
}
