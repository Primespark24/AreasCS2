using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX_01
{
    public class Pentagon : EqPolygon
    {
        private double sideLen;
        public override double perimeter()
        {
            Console.WriteLine("how long are your sides?");
            sideLen = Convert.ToInt32(Console.ReadLine());
            double edge = sideLen + sideLen + sideLen + sideLen + sideLen;
            Console.WriteLine("Your perimeter is :" + edge);
            return edge;
        }
    }
}