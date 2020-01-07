using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which shape would you like to find perimeter of? Shape, EqPolygon, Circle, Triangle, Square, Pentagon");
            string choice = Console.ReadLine();
            if (choice.Contains("Shape"))
            {
                Shape shape1 = new Shape();
                shape1.perimeter();
            }

            if (choice.Contains("EqPolygon"))
            {
                EqPolygon eqPolygon1 = new EqPolygon();
                eqPolygon1.perimeter();
            }
            if (choice.Contains("Circle"))
            {
                Circle circle1 = new Circle();
                circle1.perimeter();
            }

            if (choice.Contains("Triangle"))
            {
                Triangle triangle1 = new Triangle();
                triangle1.perimeter();
            }

            if (choice.Contains("Square"))
            {
                Square square1 = new Square();
                square1.perimeter();
            }

            if (choice.Contains("Pentagon"))
            {
                Pentagon pentagon1 = new Pentagon();
                pentagon1.perimeter();
            }
        }
    }
}
