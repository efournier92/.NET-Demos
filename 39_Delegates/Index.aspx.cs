﻿using System;
using System.Activities.Expressions;
using System.Threading;

public delegate void LabelUpdater();
public partial class Index : System.Web.UI.Page
{
    protected void UpdateLabelsButton_Click(object sender, EventArgs e)
    {
        LabelUpdater lu = UpdateFirstLabel;
        lu += UpdateSecondLabel;
        lu += UpdateMainLabel;
        lu.Invoke();
    }

    public void UpdateFirstLabel()
    {
        FirstLabel.Text = "" + DateTime.Now + "<br>";
        Thread.Sleep(5000);
    }

    public void UpdateSecondLabel()
    {
        SecondLabel.Text = "" + DateTime.Now + "<br>";
        Thread.Sleep(5000);
    }

    public void UpdateMainLabel()
    {
        SecondLabel.Text = "Done Updating At: " + DateTime.Now;
    }
}