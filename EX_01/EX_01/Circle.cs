using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX_01
{
    public class Circle : Shape
    {
        private double radius;

        public double Radius
        {
            get;
            set;
        }
        public override double perimeter()
        {
            return 3.14 * radius * radius;
        }
    }
    }