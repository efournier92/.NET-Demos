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
        // allows for page title to be controlled dynamically
        Page.Title = "Simple Site In C#";

        var height = 65.00;
        // binds var height to div sampleLabel
        // $ allows for string interpolation
        sampleLabel.Text = $"Ringo's height is {height}";
        height = 55.5;
        // appends new text to existing string
        sampleLabel.Text += $"<br>George's height is {height}";

        // {var:C} interpolates variable as currency
        // {var:C} will round to nearest hundredth
        const double dollars = 25.1222;
        sampleLabel.Text += $"<br>{dollars} formatted a currency is {dollars:C}";

        // {DateTime.Now:d} gets & shows a date
        sampleLabel.Text += $"<br>Today's date is {DateTime.Now:d}";

        var positiveBalance = true;
        sampleLabel.Text += $"<br>Do I have a pisitive financial balance on {DateTime.Now:d}? (<b>{positiveBalance})</b>";


    }
}