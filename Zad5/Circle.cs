using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad5
{
    public class Circle : Shape
    {
        public Circle(double radius)
            : base(radius, radius)
        {

        }

        public override double CalculateSurface()
        {
            return Math.PI * Height * Width;
        }
    }
}
