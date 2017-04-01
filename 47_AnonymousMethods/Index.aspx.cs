using System;
using System.Threading;
using System.Collections.Generic;

public partial class Index : System.Web.UI.Page
{
    private void ShowSquare(double x)
    {
        Label.Text += "<br>" + (x*x);
    }

    protected void ShowResultsButton_Click(object sender, EventArgs e)
    {
        var vals = new List<double>(new double[] {1, 2, 3, 4, 5, 6});
        vals.ForEach(ShowSquare);
        vals.ForEach(delegate(double x)
        {
            Label.Text += "<br>" + Math.Pow(x, 3);
        });

    }
}