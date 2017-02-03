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

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        switch (DropDownList1.SelectedValue)
        {
            case "Apple": // case label
                Page.Title = "Apples"; // sets title of page as program runs
                switchLabel.Text = "Apples cost 25 cents each.";
                break; // exit the switch block
            case "Peach":
                Page.Title = "Peach";
                switchLabel.Text = "Peaches cost 50 cents each.";
                break;
            case "Pear":
                Page.Title = "Pear";
                switchLabel.Text = "Pears cost 30 cents each.";
                break;
            case "Plum":
                Page.Title = "Plum";
                switchLabel.Text = "Plums cost 75 cents each.";
                break;
        }
    }
}