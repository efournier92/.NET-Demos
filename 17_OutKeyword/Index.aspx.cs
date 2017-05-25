using System;

public partial class Index : System.Web.UI.Page
{
    // Interest is the result of a calculation done inside the method
    // Therefore, it's an out parameter
    // Value is needed to calculate the interest, but it's set in Button_Click
    private static void GetValueAndInterest(out decimal interest, ref decimal value)
    {
        interest = 0.05M * value; // Finds interest, & saves it to interest out value
        value = value + interest; // Line updates amount of money with new interest added
    }

    protected void Button_Click(object sender, EventArgs e)
    {
        // This is the amount one which we want to calculate interest
        decimal principle = 4500; // The goes in the ref keyword, so its value must be set here
        decimal interest; // This is the out value, which doesn't need to be set here
        GetValueAndInterest(out interest, ref principle);
        Label.Text = $"Final amount is {principle}";
        Label.Text += $"<br>Interest is {interest}";
    }
}
