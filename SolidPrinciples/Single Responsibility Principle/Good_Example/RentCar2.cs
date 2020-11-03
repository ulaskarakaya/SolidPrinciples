using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolidPrinciples.Single_Responsibility_Principle.Good_Example;


namespace SolidPrinciples.Single_Responsibility_Principle.Good_Example
{
    public class RentCar2
    {
        IsPayingValid2 isPayingValid2 = new IsPayingValid2();


        public string RentACar_2(int Id)
        {
            if (isPayingValid2.IsPayingValid_2(Id))

                return "Your car is ready..!";
            else

                return "Your car is not ready..!";



        }

    }  
}
