using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.Open_Closed_Principle.Good_Example.Abstraction
{
    public abstract class AirlineTickets2
    {
        public abstract double GetTotalPrice(double amount);
    }
}
