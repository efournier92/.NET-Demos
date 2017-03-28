using System;

public partial class Index : System.Web.UI.Page
{
    protected void DisplayValuesButton_Click(object sender, EventArgs e)
    {
        Label.Text = "";
        var ints = new GenericsClass<int>(new int[] { 1, 2, 3, 4, 5});
        Label.Text = ints.DisplayValues();

        var dubs = new GenericsClass<double>(new double[] { 1.0, -2.3, 3.33, 4.57, 5.8});
        Label.Text += "<br>" + dubs.DisplayValues();

        var dec = new GenericsClass<decimal>(new decimal[] { 1, 2.1M, 3, 4, 5.45M });
        Label.Text += "<br>" + dec.DisplayValues();
    }   
}