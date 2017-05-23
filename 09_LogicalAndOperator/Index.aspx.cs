using System;

public partial class Index : System.Web.UI.Page
{
    protected void SaveButton_Click(object sender, EventArgs e)
    {
        // ensure both entries are populated
        if (TextBox1.Text != "" && TextBox2.Text != "")
        {
            Label.Text = "Entries Saved!";
        }
        else
        {
            Label.Text = "ERROR: Both entries must be specified!";
        }
    }
}
