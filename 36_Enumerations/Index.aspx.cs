using System;

public enum Days { Monday = 1, Tuesday, Wednesday };

public partial class Index : System.Web.UI.Page
{
    protected void DropDownList_SelectedIndexChanged(object sender, EventArgs e)
    {
        Label.Text = "";
        switch (DropDownList.SelectedValue)
        {
            case "Monday":
                Label.Text = $"{Days.Monday} is day number {(int) Days.Monday}";
                break;
            case "Tuesday":
                Label.Text = $"{Days.Tuesday} is day number {(int) Days.Tuesday}";
                break;
            case "Wednesday":
                Label.Text = $"{Days.Wednesday} is day number {(int) Days.Wednesday}";
                break;
        }
    }
}
