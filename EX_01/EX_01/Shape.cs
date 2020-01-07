using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;

namespace EX_01
{
    public class Shape
    {
        private string color;
        public string Color
        {
            get{return color;}
            set{color = value;}
        }

        public virtual double perimeter()
        {
            Console.WriteLine("No area on a Generic shape");
            Console.WriteLine("Unkown perimeter");
            return 0.0;
        }

        }
    }