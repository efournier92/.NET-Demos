using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public delegate bool Compare(double x, double y);
public delegate double Multiply(double x, double y);
public partial class Index : System.Web.UI.Page
{
    protected void ShowResultsButton_Click(object sender, EventArgs e)
    {
        double x = 10, y = 25;
        Compare comp = (a, b) => (a == b);
        Label.Text = x + " and " + y + " are equal is: " + comp(x, y).ToString().ToUpper();
        Multiply mult = (a, b) => (a * b);
        Label.Text += x + " * " + y + " = " + mult(x, y);
    }
}