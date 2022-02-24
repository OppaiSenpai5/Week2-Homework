using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad5
{
    public abstract class Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Shape(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public abstract double CalculateSurface();
    }
}
