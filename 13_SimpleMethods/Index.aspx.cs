using System;
using System.Globalization;

public partial class Index : System.Web.UI.Page
{
    // private means this method is only reachable within this class
    // static meas we can call this method directly by its name
    // double is the data Type of the value returned by the method
    // GetIncreasedValue is the name of the method
    // double x is the data type and name of a parameter
    // paramaters serve as placeholders, through which values are passed into methods
    private static double GetIncreasedValue(double x)
    {
        // sends value of x*1.1 back to calling code
        return x * 1.1;
    }

    protected void TextBox_TextChanged(object sender, EventArgs e)
    {
        var value = Convert.ToDouble(TextBox.Text);
        var increasedValue = GetIncreasedValue(value);
        Label.Text = Convert.ToString(increasedValue, CultureInfo.CurrentCulture);
    }
}
