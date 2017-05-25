public class Product
{
    private readonly decimal _price;

    protected Product(decimal pri)
    {
        _price = pri;
    }

    public virtual string GetDesc()
    {
        return $"Price: {_price:C}";
    }
}

public class Book : Product
{
    private readonly string _title;

    public Book(string t, decimal p) : base(p)
    {
        _title = t;
    }

    public override string GetDesc()
    {
        return base.GetDesc() + $"<br>Title: {_title}";
    }
}

public class Shoe : Product
{
    private readonly string _brand;

    public Shoe(string br, decimal p) : base(p)
    {
        _brand = br;
    }

    public override string GetDesc()
    {
        return base.GetDesc() + $"<br>Title: {_brand}";
    }
}
