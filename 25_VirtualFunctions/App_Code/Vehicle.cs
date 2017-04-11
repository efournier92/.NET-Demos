/// <summary>
/// Summary description for Vehicle
/// </summary>
public class Vehicle
{
    private readonly string _make;

    protected Vehicle(string mk)
    {
        _make = mk;
    }

    public virtual string ShowInfo()
    {
        return "Make: " + _make + "<br>";
    }
}

public class Sedan : Vehicle
{
    private readonly int _numberOfDoors;

    public Sedan(string mk, int doors) : base(mk)
    {
        _numberOfDoors = doors;
    }

    public override string ShowInfo()
    {
        return base.ShowInfo() + " Number of Doors: " + _numberOfDoors;
    }
}
