public class Product
{
    private decimal price;
    public Product(decimal pri)
    {
        price = pri;
    }

    public virtual string GetDesc()
    {
        return "Price: " + price;
    }
}

public class Book : Product
{
    private string title;

    public Book(string t, decimal p) : base(p)
    {
        title = t;
    }

    public override string GetDesc()
    {
        return base.GetDesc() + "<br>Title: " + title;
    }
}

public class Shoe : Product
{
    private string brand;

    public Shoe(string br, decimal p) : base(p)
    {
        brand = br;
    }

    public override string GetDesc()
    {
        return base.GetDesc() + "<br>Title: " + brand;
    }
}