using System;
using System.Linq;
using System.Reflection.Emit;

public partial class Index : System.Web.UI.Page
{
    // interest is the result of a calculation done inside the method
    // therefore, it's an out parameter
    // value is needed to calculate the interest, but it's set in Button_Click
    private static void GetValueAndInterest(out decimal interest, ref decimal value)
    {
        interest = 0.05M*value; // Fins interest, & saves it to interest out value
        value = value + interest; // Line updates amount of money with new interest added
    }

    protected void Button_Click(object sender, EventArgs e)
    {

    }
}