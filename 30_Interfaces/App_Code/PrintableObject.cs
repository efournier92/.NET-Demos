public interface IPrintable
{
    string Print();
}

public class Person : IPrintable
{
    private string name;

    public Person(string na)
    {
        name = na;
    }

    public string Print()
    {
        return "<br>Name" + name;
    }
}

public class Document : IPrintable
{
    private string text;

    public Document(string t)
    {
        text = t;
    }

    public string Print()
    {
        return "<br>" + text;
    }

}