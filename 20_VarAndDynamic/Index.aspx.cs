using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Indexc : System.Web.UI.Page
{
    private static dynamic Increase(dynamic x)
    {
        return x * 1.1;
    }

    protected void Button_Click(object sender, EventArgs e)
    {
        dynamic z = Convert.ToDouble(TextBox1.Text);
        Label.Text = z + " increased by 10% is " + Increase(z);
        z = Convert.ToInt32(TextBox2.Text); // z's type can be changed dynamically
        Label.Text += "<br>" + z + " increased by 10% is " + Increase(z);
        var title = "Welcome"; // System automatically defines type
        Page.Title = title;

    }
}