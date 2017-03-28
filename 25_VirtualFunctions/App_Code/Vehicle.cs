/// <summary>
/// Summary description for Vehicle
/// </summary>
public class Vehicle
{
    private string make;

    public Vehicle(string mk)
    {
        make = mk;
    }

    public virtual string ShowInfo()
    {
        return "Make: " + make + "<br>";
    }
}

public class Sedan : Vehicle
{
    private int numberOfDoors;

    public Sedan(string mk, int doors) : base(mk)
    {
        numberOfDoors = doors;
    }

    public override string ShowInfo()
    {
        return base.ShowInfo() + " Number of Doors: " + numberOfDoors;
    }
}