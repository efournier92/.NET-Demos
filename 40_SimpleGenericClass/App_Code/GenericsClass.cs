using System.Linq;

public class GenericsClass<T>
{
    private readonly T[] _vals;
    public GenericsClass(T[] input)
    {
        _vals = input;
    }

    public string DisplayValues()
    {
        return _vals.Aggregate<T, string>(null, (current, t) => current + ("<br>Value = " + t));
    }
}