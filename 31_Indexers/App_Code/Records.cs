public class Records
{
    public double[] records = new double[] { 42, 9, -5, 7, 101, -57, 70};

    public double this[int i]
    {
        get { return records[i]; }
        set { records[i] = value; }
    }

    public int Length
    {
         get { return records.Length; }
    }
}