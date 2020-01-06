using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX_01
{
    public class Square : EqPolygon
    {
        public double sideLen;

        public override double perimeter()
        {
            return sideLen + sideLen + sideLen + sideLen;
        }
    }
}