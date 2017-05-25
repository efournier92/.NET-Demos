using System;

public partial class Index : System.Web.UI.Page
{
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
