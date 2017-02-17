using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Index : System.Web.UI.Page
{
    protected void GetMakeButton_Click(object sender, EventArgs e)
    {
        var sedanMakeModel = SedanTextBox.Text.Split(new char[] {','});
        var truckMakeModel = TruckTextBox.Text.Split(new char[] {','});
        var trk = new Truck(truckMakeModel[0], truckMakeModel[1]);
        var sed = new Sedan(sedanMakeModel[0], sedanMakeModel[1]);
        SedanTextBox.Text = "Sedan: " + sed.GetSedanMake();
        TruckTextBox.Text = "Truck: " + trk.GetTruckMake();
    }
}