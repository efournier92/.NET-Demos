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
        throw new System.NotImplementedException();
    }
}