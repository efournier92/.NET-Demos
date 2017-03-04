using System;
using System.Collections.Generic;
using System.Linq;

public partial class Index : System.Web.UI.Page
{
    protected void SearchButton_Click(object sender, EventArgs e)
    {
        Label.Text = "";
        var carList = new List<Car>
        {
            new Car("Toyota,Corolla", null),
            new Car(null, "Ringo Starr"),
            new Car("Saab,9-5", "Billy Mitchell"),
            null
        };
        foreach (var c in carList.Where(c => c != null))
        {
            if (c.MakeModel != null)
            {
                Label.Text += "<br>Make: " + c.MakeModel.Split(new char[] { ',' })[0];
                if (c.MakeModel.Split(new char[] { ',' })[1] != null)
                {
                    Label.Text += "<br>Model: " + c.MakeModel.Split(new char[] { ',' })[1];
                }
                else
                {
                    Label.Text += "<br>Model: NULL";
                }
            }
            else
            {
                Label.Text += "<br>Make: NULL";
                Label.Text += "<br>Model: NULL";
            }
            if (c.PreviousOwner != null)
            {
                Label.Text += "<br>Previous Owner: " + c.PreviousOwner;
            }
            else
            {
                Label.Text += "<br>Previous Owner: NULL";
            }
            Label.Text += "<br>";
        }
    }
}