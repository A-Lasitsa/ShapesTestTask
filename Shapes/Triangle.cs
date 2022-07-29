using System;

namespace Shapes
{
    public class Triangle
    {
        // Find area of a triangle from 3 sides
        public double Area(double a, double b, double c)
        {
            if (!IsTriangle(a, b, c))
                return 0;
            double s = (a + b + c) * 0.5;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }
        public bool IsRightAngled(double a, double b, double c)
        {
            if (!IsTriangle(a, b, c))
                return false;
            double h = Math.Max(Math.Max(a, b), c);
            if (h * h == a * a + b * b)
                return true;
            return false;
        }
        public bool IsTriangle(double a, double b, double c)
        {
            if (a == 0 | b == 0 | c == 0)
                return false;
            if (a + b < c | a + c < b | b + c < a)
                return false;
            return true;
        }
    }
}
