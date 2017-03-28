using System;

/// <summary>
/// Summary description for GenericMethod
/// </summary>
public static class GenericMethod
{
    public static void Swap<T>(ref T x, ref T y)
    {
        var temp = x;
        x = y;
        y = temp;
    }

    public static string Compare<T>(T x, T y) where T : IComparable
    {
        if (x.CompareTo(y) < 0)
        {
            return x + " < " + y;
        }
        return x + " > " + y;
    }
}