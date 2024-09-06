using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    public class Circle : IShape
    {
        double radius;

       public Circle(double Radius) 
        {
            radius = Radius;
        }

        public double CalculateArea() 
        {
            return Math.PI* radius*radius;
        }
    }
}
