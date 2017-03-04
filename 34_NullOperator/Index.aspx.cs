using System;
using System.Activities.Statements;
using System.Collections.Generic;


public partial class Index : System.Web.UI.Page
{
    protected void SearchButton_Click(object sender, EventArgs e)
    {
        Label.Text = "";
        var carList = new List<Car>();
        carList.Add(new Car("Toyota,Corolla", null));
        carList.Add(new Car(null, "Ringo Starr"));
        carList.Add(new Car("Saab,9-5", "Billy Mitchell"));
        carList.Add(null);
        foreach (var c in carList)
        {
            if (c != null)
            {
                if (c.MakeModel != null)
                {
                    Label.Text += "<br>Make: " + c.MakeModel.Split(new char[] { ',' })[0];
                    if (c.MakeModel.Split(new char[] {','})[1] != null)
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
}