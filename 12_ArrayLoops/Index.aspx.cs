using System;

public partial class Index : System.Web.UI.Page
{
    protected void Button_Click(object sender, EventArgs e)
    {
        // instantiate array of strings
        string[] s = { "h", "e", "y" };
        foreach (var c in s)
            Label.Text += $"<br> {c}";
    }
}
