using System;

public partial class Index : System.Web.UI.Page
{
    protected void DivideButton_Click(object sender, EventArgs e)
    {
        try
        {
            var val1 = Convert.ToDouble(ValueBox1.Text);
            var val2 = Convert.ToDouble(ValueBox2.Text);
            if (val2 == 0)
            {
                throw new DivideByZeroException();
            }
            else
            {
                var quotient = val1/val2;
                Label.Text = val1 + "/" + val2 + " = " + quotient;
            }
        }
        catch (DivideByZeroException ex)
        {
            Label.Text = ex.Message;
        }
        catch (FormatException ex)
        {
            Label.Text = ex.Message;
        }
        finally
        {
            Label.Text += "<br>OPERATION COMPLETE.";
        }
    }
}