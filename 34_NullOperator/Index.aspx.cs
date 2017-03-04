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
                if (c.MakeModel != null)
                    Label.Text += "<br>Make: " + c.MakeModel.Split(new char[] {','})[0];
                Label.Text += "ERROR";
        }
    }
}