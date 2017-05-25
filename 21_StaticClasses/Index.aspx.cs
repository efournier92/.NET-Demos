using System;

public partial class Index : System.Web.UI.Page
{
    protected void Button_Click(object sender, EventArgs e)
    {
        Label.Text = StringUntil.Reverse(TextBox.Text);
    }
}

public static class StringUntil
{
    public static string Reverse(string s)
    {
        var chars = s.ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }
}
