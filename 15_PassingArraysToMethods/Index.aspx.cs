using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Index : System.Web.UI.Page
{
    private static double Sum(double[] values)
    {
        // begin sum with 0
        double sum = 0;

        // add each value in list
        foreach (var d in values)
            sum += d;

        return sum;
    }

    protected void Button_Click(object sender, EventArgs e)
    {
        // sample values
        double[] vals = { 4, 5, 9, -10, 2 };

        // call sum method 
        var sum = Sum(vals);

        // print result of sum method
        Label.Text = "The sum of those values is " + Convert.ToString(sum);
    }
}