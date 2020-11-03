using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.Liskov_s_Substitution_Principle.Bad_Examples
{
    public class BadRetangle
    {
        public virtual int Height { get; set; }
        public virtual int Width { get; set; }
    }
}
