using System;
using System.Linq;

namespace Zad5
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes =
            {
                new Rectangle(3, 4),
                new Triangle(3, 4),
                new Circle(3),
                new Circle(5),
                new Triangle(5, 7),
                new Rectangle(8, 9)
            };

            var surfaceAreas = shapes.Select(x => x.CalculateSurface());
            foreach (var area in surfaceAreas)
            {
                Console.WriteLine($"{area:.##}");
            }
        }
    }
}
