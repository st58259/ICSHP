using System;
using System.Collections.Generic;
using System.Text;

namespace BaseLib
{
    public class ExtraMath
    {

        public static bool QuadraticEquation(double a, double b, double c, out double x1, out double x2)
        {
            double d;

            d = b * b - 4 * a * c;
            if (d == 0)
            {
                x1 = -b / (2.0 * a);
                x2 = x1;
                return true;
            }
            else if (d > 0)
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
                return true;
            }
            else
            {
                x1 = 0;
                x2 = 0;
                return false;
            }
        }

        public static double GenerateDouble(Random r, double min, double max)
        {
            return (r.NextDouble() * max) + min;
        }


    }
}
