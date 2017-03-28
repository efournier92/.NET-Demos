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

    protected void Button_Click(object sender, EventArgs e)
    {
        // execute if either or both checkboxes are selected
        if (CheckBox1.Checked || CheckBox2.Checked)
        {
            Label.Text = "No Discount for You!";
        }
        else
        {
            // runs when neither box is checked
            Label.Text = "You Qualify for a Discount!";
        }
    }
}