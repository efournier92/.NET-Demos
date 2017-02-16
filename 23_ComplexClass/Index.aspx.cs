using System;

public partial class Index : System.Web.UI.Page
{
    protected void TextBox_TextChanged(object sender, EventArgs e)
    {
        var tr = new Truck(TextBox.Text);
        Label.Text = "There are " + Truck._count + " trucks(s)";
    }
}