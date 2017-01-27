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
        // label is an object
        // objects pass features, like text property
        sampleLabel.Text = "Hello, World!";
    }
}