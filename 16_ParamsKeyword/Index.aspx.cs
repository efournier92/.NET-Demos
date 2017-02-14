using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    // params keyword lets us pass a variable number of values into a method
    // Product(1,2) or Product(-3,4,3,6)
    private static double Product(params double[] arr)
    {
        double product = 1;

        foreach (double d in arr)
            product *= d;

        return product;
    }

    protected void Button_Click(object sender, EventArgs e)
    {
        double x = 5, y = 10, z = 15;
        Label.Text = x + "*" + y + "=" + Product(x, y);
        Label.Text += "<br>" + x + "*" + y + "*" + z + "=" + Product(x, y, z);
    }
}