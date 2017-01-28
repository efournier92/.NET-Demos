using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void sampleButton_Click(object sender, EventArgs e)
    {
        var numTimes = 5; // Represents how many times the loop in run
        var counter = 1;

        while (counter <= numTimes)
        {
            sampleLabel.Text += "<br>" + counter + " Squared = " + Math.Pow(counter,2);
            counter++;
        }    
    }
}