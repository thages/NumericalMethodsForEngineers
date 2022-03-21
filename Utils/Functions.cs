namespace Utils
{
    public class Functions
    {

        public double ApproximateError(double x, double xold)
        {
            return Math.Abs((x - xold) / x) * 100;
        }

    }
}

