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
    private double _radius;

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
    private double edge;

    public Cube(double edgeLength)
    {
        edge = edgeLength;
    }

    public override double GetVolume()
    {
        return Math.Pow(edge, 3);
    }
}