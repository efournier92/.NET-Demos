﻿using System;
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

/// <summary>
/// Summary description for GenericInterface
/// </summary>
public class GenericInterface
{
    public GenericInterface()
    {

    }
}