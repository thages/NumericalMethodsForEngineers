using Utils;

namespace BracketingMethods
{
    public class Bisection : Functions
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
                xr = Math.Round((xl + xu) / 2,4);

                if (xr != 0)
                {
                    ea = Math.Round(ApproximateError(xr, xrold), 4);
                }
                test = Math.Round(F(xl) * F(xr),4);

                switch (test)
                {
                    case < 0:
                        xu = xr;
                        break;
                    case > 0:
                        xl = xr;
                        break;
                    default:
                        ea = 0;
                        break;
                }
                
                Console.WriteLine($"  {i}   |   {xl}   |   {xu}   |   {xr}   |   {ea}\n");

                if (ea < es)
                {
                    break;
                }

            }

            return xr;
        }

       
    }
}
