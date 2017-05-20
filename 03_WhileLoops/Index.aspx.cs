using System;

public partial class Index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void numSquares_TextChanged(object sender, EventArgs e)
    {
        sampleLabel.Text = "";
        var numTimes = Convert.ToInt32(numSquares.Text);
        var counter = 1;

        while (counter <= numTimes)
        {
            // list squared values of all ints below numTimes
            sampleLabel.Text += "<br>" + counter + " Squared = " + Math.Pow(counter, 2);
            counter++;
        }
    }
}
