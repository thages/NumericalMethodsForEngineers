using Utils;

namespace BracketingMethods
{
    public class FalsePositionService : Functions
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

        private double F(double x)
        {
            return Math.Pow(x, 10) - 1;
        }

        public double ModFalsePos(double xl, double xu,  double es, int imax)
        {
            Console.WriteLine($" Iter |   Xl   |   Xu   |   Xr   |   Ea\n");

            fl = F(xl);
            fu = F(xu);

            for (int i = 0; i <= imax; i++)
            {
                xrold = xr;

                xr = Round((xu - fu) * (xl - xu) / (fl - fu), 5);
                fr = F(xr);
                
                if (xr != 0)
                {
                    ea = Round(ApproximateError(xr, xrold), 5);
                };

                test = fl * fr;

                if (test < 0) 
                {
                    xu = xr;
                    fu = F(xu);
                    iu = 0;
                    il++;

                    if ( il >= 2)
                    {
                        fl /= 2;
                    }

                } else if (test > 0)
                {
                    xl = xr;
                    fl = F(xl);
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
