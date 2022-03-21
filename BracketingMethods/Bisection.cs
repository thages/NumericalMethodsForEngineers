using Utils;

namespace BracketingMethods
{
    public class BisectionServices : Functions
    {
        private double xrold;
        private double xr;
        private double test;
        private double ea;

        private double F(double x)
        {
            return Math.Sin(10 * x) + Math.Cos(3 * x);
        }

        public double Bisect(double xl, double xu, double es, int imax)
        {
            Console.WriteLine($" Iter |   Xl   |   Xu   |   Xr   |   Ea\n");
            for(int i  = 0; i <= imax; i++)
            {
                xrold = xr;
                xr = Round((xl + xu) / 2,4);

                if (xr != 0)
                {
                    ea = Round(ApproximateError(xr, xrold), 4);
                }
                test = Round(F(xl) * F(xr),4);

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
