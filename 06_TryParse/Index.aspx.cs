using System;

public partial class Index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void tryParseButton_Click1(object sender, EventArgs e)
    {
        double xOut;
        // attempts to convert input value to double
        if (double.TryParse(tryParseTextBox.Text, out xOut))
        {
            // line runs when input can be successfully converted to numerical value
            tryParseLabel.Text = "110% of " + xOut + " is " + xOut*1.1;
        }
        else
        {
            // line runs when input fails conver to numerical value
            tryParseLabel.Text = "Failed to convert input to numerical value";
        }
    }
}