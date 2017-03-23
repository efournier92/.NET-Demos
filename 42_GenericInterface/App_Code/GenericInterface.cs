using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;

public class Quad : IComparable<Quad>
{
    private string name;

    public Quad(string na)
    {
        name = na;
    }

    public int CompareTo(Quad other)
    {
        if (this.name.CompareTo(other.name) < 0)
        {
            return -1;
        }
        else
        {
            return 1;
        }
    }

    public virtual string Perimeter()
    {
        return "The perimeter of " + name + " is " + 
    }
}

public class Square : Quad
{

}

/// <summary>
/// Summary description for GenericInterface
/// </summary>
public class GenericInterface
{
    public GenericInterface()
    {

    }
}