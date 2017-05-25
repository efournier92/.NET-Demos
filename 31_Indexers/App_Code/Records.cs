public class Records
{
    private readonly double[] _records = { 42, 9, -5, 7, 101, -57, 70 };

    public double this[int i]
    {
        get { return _records[i]; }
        set { _records[i] = value; }
    }

    public int Length
    {
        get { return _records.Length; }
    }
}
