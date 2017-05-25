using System;
using System.Linq;

public partial class Index : System.Web.UI.Page
{
    // params keyword lets us pass a variable number of values into a method
    // Product(1,2) or Product(-3,4,3,6)
    private static double Product(params double[] arr)
    {
        return arr.Aggregate<double, double>(1, (current, d) => current*d);
    }

    protected void Button_Click(object sender, EventArgs e)
    {
        const double x = 5, y = 10, z = 15;
        Label.Text = $"{x} * {y} = {Product(x, y)}";
        Label.Text += $"<br> {x} * {y} * {z} = {Product(x, y, z)}";
    }
}
