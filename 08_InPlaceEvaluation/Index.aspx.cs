﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    // Button_Click is code that runs when a page loads from server
    protected void Button_Click(object sender, EventArgs e)
    {
        double x = 25;
        Label.Text = x + " Single Increased Is " + ++x;
        Label.Text += "<br>" + x + " Double Increased Is " + (x += 2);
        Label.Text += "<br>" + x + " Single Decreased Is " + (--x);
        Label.Text += "<br>" + x + " Double Decreased Is " + (x -= 2);
        Label.Text += "<br>Does x = 3? " + (x == 3);
        Label.Text += "<br>Does x = 25? " + (x == 25);
    }
}