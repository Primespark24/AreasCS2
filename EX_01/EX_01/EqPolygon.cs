using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX_01
{
    public class EqPolygon : Shape
    {
        private double sideLen;
        public double SideLen
        {
            get;
            set;
        }
        public override double perimeter()
        {
            Console.WriteLine("How many sides do you have");
            int side = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How long are your sides");
            sideLen = Convert.ToInt32(Console.ReadLine());
            double edge = side * sideLen;
            Console.WriteLine("Your perimeter is :" + edge);
            return edge;
        }
    }
    }