using System;
using System.Collections.Generic;

public partial class Index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button_Click(object sender, EventArgs e)
    {
        var d = new List<double>();
        d.Add(Convert.ToDouble(TextBox1.Text));
        d.Add(Convert.ToDouble(TextBox2.Text));
        d.Add(Convert.ToDouble(TextBox3.Text));
        //Label.Text = 
    }
}