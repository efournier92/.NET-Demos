using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    
    protected void numInput_TextChanged(object sender, EventArgs e)
    {
        var n = Convert.ToInt32(numInput.Text);
        var i = 0;
        for ( ; i <= n; i++)
        {
            numOutput.Text += "<br>" + i;
        }
    }
}