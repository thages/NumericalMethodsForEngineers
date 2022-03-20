using System;
using System.Collections.Generic;

namespace BracketingMethods.Utils
{
    public class Functions
    {
        public double Fn1(double x)
        {
            return Math.Sin(10 * x) + Math.Cos(3 * x);
        }

        public double Fn2(double x)
        {
            return Math.Pow(x, 10) - 1;
        }


        public double Round(double value, int decimals)
        {
            double power = Math.Pow(10.0, decimals);
            return Math.Truncate((power * value)) / power;
        }
    }
}
