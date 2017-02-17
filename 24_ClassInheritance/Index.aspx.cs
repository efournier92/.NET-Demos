using System;

public partial class Index : System.Web.UI.Page
{
    protected void GetMakeButton_Click(object sender, EventArgs e)
    {
        var sedanMakeModel = SedanTextBox.Text.Split(new char[] {','});
        var truckMakeModel = TruckTextBox.Text.Split(new char[] {','});
        var trk = new Truck(truckMakeModel[0], truckMakeModel[1]);
        var sed = new Sedan(sedanMakeModel[0], sedanMakeModel[1]);
        SedanLabel.Text = "Sedan Make: " + sed.make;
        SedanLabel.Text += "<br>Sedan Model: " + sed.model + "<br>";
        TruckLabel.Text = "Truck Make: " + trk.make;
        TruckLabel.Text += "<br>Truck Model: " + trk.model;
    }
}