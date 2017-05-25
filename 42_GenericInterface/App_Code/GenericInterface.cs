using System;

public class Quad : IComparable<Quad>
{
    private string name;

    internal Quad(string na)
    {
        name = na;
    }

    public int CompareTo(Quad other)
    {
        if (string.Compare(name, other.name, StringComparison.Ordinal) < 0)
        {
            return -1;
        }
        return 1;
    }

    public virtual string Perimeter()
    {
        return "The perimeter of " + name + " is ";
    }
}

public class Square : Quad
{
    private double sideLen;

    public Square(string n, double s) : base(n)
    {
        sideLen = s;
    }
    public override string Perimeter()
    {
        return base.Perimeter() + 4 * sideLen;
    }
}
public class Rectangle : Quad
{
    private double sideOne, sideTwo;

    public Rectangle(string n, double s1, double s2) : base(n)
    {
        sideOne = s1;
        sideTwo = s2;
    }
    public override string Perimeter()
    {
        return base.Perimeter() + (2 * sideOne + 2 * sideTwo);
    }
}
