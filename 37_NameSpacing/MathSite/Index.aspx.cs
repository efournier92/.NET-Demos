using System;
using MathLibrary;

public partial class Index : System.Web.UI.Page
{

    protected void AddButton_Click(object sender, EventArgs e)
    {
        var basicMath = new BasicMath();
        SumLabel.Text = "" + basicMath.Add(double.Parse(Value1Box.Text), double.Parse(Value2Box.Text));
    }
    
    protected void FindInterestButton_Click(object sender, EventArgs e)
    {
        var financialMath = new FinancialMath();
        InterestLabel.Text = "" + financialMath.GetInterest(double.Parse(RateBox.Text), double.Parse(PricipleBox.Text));
    }
}