using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.Single_Responsibility_Principle.Bad_Example
{
    public class RentCar
    {
        int Id;
        
        public string RentACar()
        {
            if (IsPayingValid(Id))
            
                return "Your car is ready..!";
           
            else
            
                return "Your car is not ready..!";
            
        }
        public bool IsPayingValid(int Id)
        {
            return true;
        }


    }
        
    
}
