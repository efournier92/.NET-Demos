public class GenericsClass<T>
{
    private T[] vals;
    public GenericsClass(T[] input)
    {
        vals = input;
    }

    public string DisplayValues()
    {
        string str = null;
        foreach (var T in vals)
        {
            str += "<br>Value = " + 
        }
    }
}