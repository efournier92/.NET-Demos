using System;

public partial class Index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void numInput_TextChanged(object sender, EventArgs e)
    {
        numOutput.Text = "";
        var n = Convert.ToInt32(numInput.Text);
        var i = 0;
        for (; i <= n; i++)
        {
            numOutput.Text += "<br>" + i;
        }
    }
}
