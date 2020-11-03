using SolidPrinciples.Liskov_s_Substitution_Principle.Good_Examples.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.Liskov_s_Substitution_Principle.Good_Examples.Concrete
{
    public class Retangle:Shape
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public double RetangleArea()
        {
            return Width * Height;
        }
    }
}
