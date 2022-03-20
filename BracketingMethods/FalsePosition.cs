using System;

namespace BracketingMethods
{
    public class FalsePositionService : Utils.Functions
    {
        private double xrold;
        private double xr;
        private double ea;
        private double test;
        private double fl;
        private double fu;
        private double fr;
        private int iu;
        private int il;
        
        public double ModFalsePos(double xl, double xu,  double es, int imax)
        {
            Console.WriteLine($" Iter |   Xl   |   Xu   |   Xr   |   Ea\n");

            fl = Fn2(xl);
            fu = Fn2(xu);

            for (int i = 0; i <= imax; i++)
            {
                xrold = xr;

                xr = Round((xu - fu) * (xl - xu) / (fl - fu), 5);
                fr = Fn2(xr);
                
                if (xr != 0)
                {
                    ea = Round(Math.Abs((xr - xrold) / xr) * 100, 5);
                };

                test = fl * fr;

                if (test < 0) 
                {
                    xu = xr;
                    fu = Fn2(xu);
                    iu = 0;
                    il++;

                    if ( il >= 2)
                    {
                        fl /= 2;
                    }

                } else if (test > 0)
                {
                    xl = xr;
                    fl = Fn2(xl);
                    il = 0;
                    iu++;
                    
                    if (iu >= 2)
                    {
                        fu /= 2;
                    }
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
