using System;

public partial class Index : System.Web.UI.Page
{
    protected void ECButton_Click(object sender, EventArgs e)
    {
        double x = 25, y = 34;
        Label.Text = "x = " + x + ", y = " + y;
        GenericMethod.Swap(ref x, ref y);
        Label.Text += "<br>x = " + x + ", y = " + y;
        Label.Text += "<br><br>" + GenericMethod.Compare(x, y);
    }
}
