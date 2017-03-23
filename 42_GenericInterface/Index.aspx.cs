using System;
using System.Collections.Generic;

public partial class Index : System.Web.UI.Page
{
    protected void SortandShowButton_Click(object sender, EventArgs e)
    {
        Label.Text = "";
        Quad sqr = new Square("Square", 4);
        Quad rect = new Rectangle("Rectangle", 2, 5);
        List<Quad> lst = new List<Quad>(new Quad[] {sqr, rect});
        lst.Sort();
        if (lst[0] is Square)
        {
            Label.Text += "" + ((Square)lst[0]).Perimeter();
        }
        else if (lst[0] is Rectangle)
        {
            Label.Text += ((Rectangle) lst[0]).Perimeter();
        }
    }
}