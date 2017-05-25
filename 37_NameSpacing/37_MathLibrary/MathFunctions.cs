namespace MathLibrary
{
    public class BasicMath
    {
        public static double Add(double x, double y)
        {
            return x + y;
        }
    }
    public class FinancialMath
    {
        public static double GetInterest(double principle, double rate)
        {
            return principle * rate;
        }
    }
}
