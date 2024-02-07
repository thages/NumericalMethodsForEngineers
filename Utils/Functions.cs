namespace Utils
{
    public abstract class Functions
    {
        protected virtual double ApproximateError(double x, double xold)
        {
            return Math.Abs((x - xold) / x) * 100;
        }

    }
}

