using System;
using System.Reflection.Emit;
using StructLibrary;

public partial class Index : System.Web.UI.Page
{

    protected void MakePoints_Click(object sender, EventArgs e)
    {
        PointsLabel.Text = "";
        var points= new Point[10];
        for (var i = 0; i < points.Length; i++)
        {
            points[i] = new Point(new Random().Next(-10, 10), new Random().Next(-10, 10));
        }
        foreach (var p in points)
        {
            PointsLabel.Text += "(" + p.X + "," + p.Y + ")";
        }
    }
}