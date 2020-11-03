using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.Liskov_s_Substitution_Principle.Bad_Examples
{
    public class BadSquare:BadRetangle
    {
        int _height;
        int _witdh;

        public override int Height
        {
            get { return _height; }
            set { _height = value; _witdh = value; }
        }

        public override int Width
        {
            get { return _witdh; }
            set { _height = value; _witdh = value; }
        }
    }
}
