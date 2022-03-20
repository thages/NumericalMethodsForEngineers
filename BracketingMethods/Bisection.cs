using System;

namespace BracketingMethods
{
    public class BisectionServices : Utils.Functions
    {
        private double xrold;
        private double xr;
        private double test;
        private double ea;
        

        public double Bisect(double xl, double xu, double es, int imax)
        {
            Console.WriteLine($" Iter |   Xl   |   Xu   |   Xr   |   Ea\n");
            for(int i  = 0; i <= imax; i++)
            {
                xrold = xr;
                xr = Round((xl + xu) / 2,4);

                if (xr != 0)
                {
                    ea = Round(Math.Abs((xr - xrold) / xr) * 100,4);
                }
                test = Round(Fn1(xl) * Fn1(xr),4);

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

                if (ea < es)
                {
                    break;
                }

            }

            return xr;

            throw new NotImplementedException("Please create a test first");
        }

       
    }
}
