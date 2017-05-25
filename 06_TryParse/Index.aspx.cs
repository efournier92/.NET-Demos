using System;

public partial class Index : System.Web.UI.Page
{
    protected void tryParseButton_Click(object sender, EventArgs e)
    {
        double xOut;
        // attempts to convert input value to double
        tryParseLabel.Text = double.TryParse(tryParseTextBox.Text, out xOut) 
            ? $"110% of {xOut} is {xOut * 1.1}"
            : "Failed to convert input to numerical value";
    }
}
