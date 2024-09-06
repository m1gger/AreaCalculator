using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    public class Triangle : IShape
    {
        private  double a_side;
        private double b_side;
        private double c_side;

        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentException("Sides must be greater than zero.");
            if (!IsValidTriangle(a, b, c))
                throw new ArgumentException("The sides do not form a valid triangle.");

            a_side = a;
            b_side = b;
            c_side = c;
        }

        public double CalculateArea() 
        {
            double s = (a_side + b_side + c_side) / 2;
            return Math.Sqrt(s * (s - a_side) * (s - b_side) * (s - c_side));
        }

        private bool IsValidTriangle(double a, double b, double c)
        {
            return a + b > c && a + c > b && b + c > a;
        }

        public bool IsRightAngled()
        {
            double[] sides = { a_side,b_side, c_side };
            Array.Sort(sides);
            return Math.Abs(sides[2] * sides[2] - (sides[0] * sides[0] + sides[1] * sides[1])) < 1e-10;
        }
    }
}
