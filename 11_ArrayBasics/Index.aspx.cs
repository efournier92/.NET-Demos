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
    
    protected void SummarizeButton_Click(object sender, EventArgs e)
    {
        // create array that can store 2 entries
        decimal[] values = new decimal[2];
        // converts & saves value from box to values[0]
        values[0] = decimal.Parse(TextBox1.Text);
        // converts & saves value from box to valu es[1]
        values[1] = decimal.Parse(TextBox2.Text);
        // add array values together
        decimal total = values[0] + values[1];
        // display total value
        Label.Text = "Total Is " + total;
        // return arithmetical average
        Label.Text += "<br>Average Is " + (total / values.Length);
    }
}