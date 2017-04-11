using System;

public partial class Index : System.Web.UI.Page
{
    protected void Button_Click(object sender, EventArgs e)
    {
        var sedan = new Sedan(MakeBox.Text, int.Parse(DoorBox.Text));
        Label.Text = sedan.ShowInfo();
    }
}
