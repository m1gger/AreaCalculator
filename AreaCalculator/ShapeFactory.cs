using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    public static class ShapeFactory
    {
        public static IShape CreateTriangle(double a, double b, double c) 
        {
            return new Triangle(a, b, c);
        }

        public static IShape CreateCircle(double radius) 
        {
            return new Circle(radius);
        }
    }
}
