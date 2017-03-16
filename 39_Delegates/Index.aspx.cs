using System;
using System.Activities.Expressions;
using System.Threading;

public delegate void LabelUdater();
public partial class Index : System.Web.UI.Page
{
    protected void UpdateLabelsButton_Click(object sender, EventArgs e)
    {

    }

    public void UpdateFirstLabel()
    {
        FirstLabel.Text = "" + DateTime.Now;
        Thread.Sleep(5000);
    }

    public void UpdateSecondLabel()
    {
        SecondLabel.Text = "" + DateTime.Now;
        Thread.Sleep(5000);
    }

    public void UpdateMainLabel()
    {
        SecondLabel.Text = "Done Updating At: " + DateTime.Now;
    }
}