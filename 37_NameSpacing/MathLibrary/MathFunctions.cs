namespace MathLibrary
{
    public class BasicMath
    {
        public double Add(double x, double y)
        {
            return x + y;
        }
    }
    public class FinancialMath
    {
        public double GetInterest(double principle, double rate)
        {
            return principle * rate;
        }
    }
}
