using SolidPrinciples.Liskov_s_Substitution_Principle.Good_Examples.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.Liskov_s_Substitution_Principle.Good_Examples.Concrete
{
    public class Square:Shape
    {
        public int Width { get; set; }

        public double SquareArea()
        {
            return Width * Width;
        }
    }
}
