public interface IPrintable
{
    string Print();
}

public class Person : IPrintable
{
    private readonly string _name;

    public Person(string na)
    {
        _name = na;
    }

    public string Print()
    {
        return $"<br>Name: {_name}";
    }
}

public class Document : IPrintable
{
    private readonly string _quote;

    public Document(string t)
    {
        _quote = $"{t}";
    }

    public string Print()
    {
        return $"<br>Quote: \"{_quote}\"<br>";
    }

}
