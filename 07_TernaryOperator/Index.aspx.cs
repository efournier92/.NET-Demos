using System;

public partial class Index : System.Web.UI.Page
{
    protected void ternaryButton_Click(object sender, EventArgs e)
    {
        double xOut, yOut; // we'll try to set these variables using TryParse
        // combines ternary operator with TryParse
        // if conversion is successful, xOut is saved to x
        // if conversion fails, xOut gets the value 0
        var x = double.TryParse(ternaryTextBox01.Text, out xOut) ? xOut : 0;

        // same logic applys to y
        var y = double.TryParse(ternaryTextBox02.Text, out yOut) ? yOut : 0;
        ternaryLabel.Text = $"{xOut} + {yOut} = {x + y}";
    }
}
