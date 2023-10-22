using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquApp
{
    public class SquareRoot
    {
        double a = 0;  double b = 0; double  c = 0;
        public double TurnNegative(double b) 
        {
            return (-1 * b);
        }

        public double CalculateSqrt (double a, double b, double c)
        {
            var Calcresult = Math.Sqrt((b * b) - (4 * a * c) );
            return Calcresult;
        }

        public double Divisor (double a)
        {
            return (2 * a);
        }
    }
}
