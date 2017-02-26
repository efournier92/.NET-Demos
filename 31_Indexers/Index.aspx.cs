using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Index : System.Web.UI.Page
{
    protected void GetRecordsButton_Click(object sender, EventArgs e)
    {
        var recs = new Records();
        for (int i = 0; i < recs.Length; i++)
        {
            Label.Text += "<br>" + recs[i];
        }
    }
}