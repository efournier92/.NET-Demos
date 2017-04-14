using System;

public delegate bool Compare(double x, double y);
public delegate double Multiply(double x, double y);
public partial class Index : System.Web.UI.Page
{
    protected void ShowResultsButton_Click(object sender, EventArgs e)
    {
        Label.Text = "";
        const double x = 10, y = 25;
        Compare comp = (a, b) => (a == b);
        Label.Text = $"<br>{x} & {y} are equal? {comp(x, y).ToString().ToUpper()}";
        Multiply mult = (a, b) => (a * b);
        Label.Text += $"<br>{x} * {y} = {mult(x, y)}";
        var dubsArray = new double[] { 1, 2, 3, 4, 5 };
        Action<double> showDouble = (a) => Label.Text += $"<br> {a * a}";
        foreach (var d in dubsArray)
        {
            showDouble(d);
        }
    }
}
