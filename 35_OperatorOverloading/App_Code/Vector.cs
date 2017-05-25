public class Vector
{
    private double XCoord { get; set; }
    private double YCoord { get; set; }

    public Vector(double x, double y)
    {
        XCoord = x;
        YCoord = y;
    }

    public static Vector operator +(Vector vec1, Vector vec2)
    {
        return new Vector(vec1.XCoord + vec2.XCoord, vec1.YCoord + vec2.YCoord);
    }

    public override string ToString()
    {
        return $"<{XCoord},{YCoord}>";
    }
}
