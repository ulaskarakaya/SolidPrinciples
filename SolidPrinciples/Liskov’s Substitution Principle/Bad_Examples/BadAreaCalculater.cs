using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.Liskov_s_Substitution_Principle.Bad_Examples
{
    public class BadAreaCalculater
    {
        public static double CalCulateArea(BadRetangle retangle)
        {
            return retangle.Height * retangle.Width;
        }

        public static double CalculateArea(BadSquare square)
        {
            return square.Width * square.Height;
        }
    }
}
