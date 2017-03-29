using System;

public delegate void Summarize<T>(T x, T y);
public partial class Index : System.Web.UI.Page
{

    protected void SummarizeButton_Click(object sender, EventArgs e)
    {
        Label.Text = "";
        Summarize<double> s = FindSum;
        s += FindRatio;
        s += FindProduct;
        s(4, 8);
    }

    public void FindSum(double x, double y)
    {
        Label.Text += "<br>" + x + " + " + y + " = " + (x + y);
    }

    public void FindRatio(double x, double y)
    {
        Label.Text += "<br><br>" + x + " / " + y + " = " + (x / y);
    }
    public void FindProduct(double x, double y)
    {
        Label.Text += "<br><br>" + x + " * " + y + " = " + (x * y);
    }

}