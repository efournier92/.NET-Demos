using System;

/// <summary>
/// Summary description for Shapes
/// </summary>
public abstract class ThreeDimShape
{
    public abstract double GetVolume();
}

public class Sphere : ThreeDimShape
{
    private readonly double _radius;

    public Sphere(double r)
    {
        _radius = r;
    }

    public override double GetVolume()
    {
        return (4.00) / (3.00) * Math.PI * Math.Pow(_radius, 3);
    }
}

public class Cube : ThreeDimShape
{
    private readonly double _edge;

    public Cube(double edgeLength)
    {
        _edge = edgeLength;
    }

    public override double GetVolume()
    {
        return Math.Pow(_edge, 3);
    }
}
