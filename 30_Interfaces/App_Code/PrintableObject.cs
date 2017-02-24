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
        return "<br>Name: " + name;
    }
}

public class Document : IPrintable
{
    private string quote;

    public Document(string t)
    {
        quote = '"' + t  + '"';
    }

    public string Print()
    {
        return "<br>Quote: " + quote + "<br>";
    }

}