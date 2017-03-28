using System;
using System.Threading;
using StructLibrary;

public partial class Index : System.Web.UI.Page
{

    protected void MakePoints_Click(object sender, EventArgs e)
    {
        PointsLabel.Text = "";
        var points= new Point[10];
        for (var i = 0; i < points.Length; i++)
        {
            var x = new Random().Next(-10, 10);
            Thread.Sleep(20);
            var y = new Random().Next(-10, 10);
            Thread.Sleep(20);
            points[i] = new Point(x, y);
            
        }
        foreach (var p in points)
        {
            PointsLabel.Text += "(" + p.X + ", " + p.Y + ")<br>";
        }
    }
}