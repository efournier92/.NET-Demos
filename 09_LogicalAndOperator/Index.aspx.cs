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

    protected void SaveButton_Click(object sender, EventArgs e)
    {
        // ensure both entries are populated
        if (TextBox1.Text != "" && TextBox2.Text != "")
        {
            Label.Text = "Entries Saved!";
        }
        else
        {
            Label.Text = "ERROR: both entries must be specified";
        }
    }
}