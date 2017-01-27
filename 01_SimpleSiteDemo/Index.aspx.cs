// using is a keyword
// system is a namespace
// using System includes existing code in project
using System;

// class isa required container for creating code samples
public partial class Index : System.Web.UI.Page
{
    // runs when the page loads
    protected void Page_Load(object sender, EventArgs e)
    {
        var height = 65.00;
        // binds var height to div sampleLabel
        // $ allows for string interpolation
        sampleLabel.Text = $"Ringo's height is {height}";
        height = 55.5;
        // appends new text to existing string
        sampleLabel.Text += $"<br>George's height is {height}";

        const double dollars = 25.1556;
        sampleLabel.Text += $"<br>{dollars} formatted a currency is {dollars:C}";
    }
}