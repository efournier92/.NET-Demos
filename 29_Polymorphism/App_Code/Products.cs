using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class Products
{
    private decimal price;
    public Products(decimal pri)
    {
        price = pri;
    }

    public virtual string GetDesc()
    {
        return "Price: " + price;
    }
}