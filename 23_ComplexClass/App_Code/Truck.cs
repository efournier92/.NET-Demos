using System;

/// <summary>
/// Truck Class
/// </summary>

public class Truck
{
    private string make;
    private static int count;
    public Truck(string name)
    {
        make = name;
        count++;
    }
    public static int TruckCount
    {
        get
        {
            return count;
        }
    }
}
