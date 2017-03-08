using System;

public partial class Index : System.Web.UI.Page
{
    protected void GetRecordsButton_Click(object sender, EventArgs e)
    {
        Label.Text = "";
        var recs = new Records();
        for (int i = 0; i < recs.Length; i++)
        {
            Label.Text += "<br>" + recs[i];
        }
        Label.Text += "<br>";
    }
}