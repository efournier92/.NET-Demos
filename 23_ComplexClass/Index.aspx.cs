using System;

public partial class Index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var tr = new Truck(TextBox.Text);
        Label.Text = Truck._count.ToString();
    }

    protected void TextBox_TextChanged(object sender, EventArgs e)
    {

    }
}