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
        for (int i = 1; i <= 10; i++)
            sampleListBox.Items.Add(i.ToString());
    }
}