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
            Console.WriteLine("how long is your radius?");
            radius = Convert.ToInt32(Console.ReadLine());
            double area = 3.14 * radius * radius;
            Console.WriteLine("Your perimeter is :" + area);
            return area;
        }
    }
    }