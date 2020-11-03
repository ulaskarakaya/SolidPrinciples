using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.Liskov_s_Substitution_Principle.Good_Examples.Abstraction
{
    public abstract class Shape
    {
        public virtual int Id { get; set; }
    }
}
