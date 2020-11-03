using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.Open_Closed_Principle.Bad_Example
{
    public enum TicketsClass
    {
        FirstClass,
        BusinessClass,
        EconomyClass
    }
    public class AirlineTickets
    {
        public double GetTotalPrice(double amount, TicketsClass ticketsClass)
        {
            double totalPrice = 0;

            if (ticketsClass == TicketsClass.EconomyClass)
            {
                totalPrice += amount * 2.50;
            }
            else if (ticketsClass == TicketsClass.BusinessClass)
            {
                totalPrice += amount * 5.25;
            }
            else if (ticketsClass == TicketsClass.FirstClass)
            {
                totalPrice += amount * 6.75;
            }

            return totalPrice;
        }

    }
}
