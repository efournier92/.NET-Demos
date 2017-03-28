using System;

/// <summary>
/// Truck Class
/// </summary>

public class Truck
{
    private string _make;
    public static int _count;
    public Truck(string name)
    {
        _make = name;
        _count++;
    }
    public static int TruckCount
    {
        get
        {
            return _count;
        }
    }
}
    