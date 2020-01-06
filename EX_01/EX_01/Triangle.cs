using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX_01
{
    public class Triangle : EqPolygon
    {
        private double sideLen;

        public override double perimeter()
        {
            return sideLen + sideLen + sideLen;
        }
    }
}