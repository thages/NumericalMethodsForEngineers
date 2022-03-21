namespace Utils
{
    public class Functions
    {

        public double Round(double value, int decimals)
        {
            double power = Math.Pow(10.0, decimals);
            return Math.Truncate((power * value)) / power;
        }

        public double ApproximateError(double x, double xold)
        {
            return Math.Abs((x - xold) / x) * 100;
        }

    }
}

