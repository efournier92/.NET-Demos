using System;

public partial class Indexc : System.Web.UI.Page
{
    private static dynamic Increase(dynamic x)
    {
        return x * 1.1;
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        Label.Text = "";
    }

    protected void Button_Click(object sender, EventArgs e)
    {
        const string title = "Var & Dynamic"; // System automatically defines type
        Page.Title = title;

        foreach (var c in Page.Title)
        {
            Label.Text += c.ToString().ToUpper();
        }

        dynamic z = Convert.ToDouble(TextBox1.Text);
        Label.Text = $"{z} increase d by 10% is {Increase(z)}";
        z = Convert.ToInt32(TextBox2.Text); // z's type can be changed dynamically
        Label.Text += $"<br> {z} increased by 10% is {Increase(z)}";
    }
}
