using System;

namespace Bisection.Services
{
    public class BisectionServices
    {
        private double xrold;
        private double test;
        private double ea;
        private int i;

        public double Bisect(double xl, double xu, double xr, double es, int imax)
        {
            Console.WriteLine($" Iter |   Xl   |   Xu   |   Xr   |   Ea\n");
            while (ea > es || i <= imax)
            {
                xrold = xr;
                xr = R((xl + xu) / 2);

                if (xr != 0)
                {
                    ea = R(Math.Abs((xr - xrold) / xr) * 100);
                }
                test = R(F(xl) * F(xr));

                if (test < 0)
                {
                    xu = xr;
                } else if (test > 0) {
                    xl = xr;
                } else
                {
                    ea = 0;
                }
                Console.WriteLine($"  {i}   |   {xl}   |   {xu}   |   {xr}   |   {ea}\n");
                i++;
            }

            return xr;

            throw new NotImplementedException("Please create a test first");
        }

        private double F(double x)
        {
            return Math.Sin(10 * x) + Math.Cos(3 * x);
        }

       
        private double R(double value)
        {
            double power = Math.Pow(10.0, 4);
            return Math.Truncate((power * value)) / power;
        }
    }
}
