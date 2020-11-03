using SolidPrinciples.Open_Closed_Principle.Good_Example.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.Open_Closed_Principle.Good_Example.Concrete
{
    public class EconomyClass : AirlineTickets2
    {
        public override double GetTotalPrice(double amount)
        {
            return amount * 2.50;
        }
    }
}
