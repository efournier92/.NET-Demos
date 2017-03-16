using System;

public partial class Index : System.Web.UI.Page
{
    protected void DisplayValuesButton_Click(object sender, EventArgs e)
    {
        GenericsClass<int> ints = new GenericsClass<int>(new int[] { 1, 2, 3, 4, 5});
        Label.Text = ints.DisplayValues();

        GenericsClass<double> dubs = new GenericsClass<double>(new double[] { 1, 2, 3, 4, 5});
        Label.Text = dubs.DisplayValues();

        GenericsClass<decimal> dec = new GenericsClass<decimal>(new decimal[] { 1, 2, 3, 4, 5 });
        Label.Text = dec.DisplayValues();
    }
}