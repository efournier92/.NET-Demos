using System;
using System.Linq;
using System.Collections.Generic;

public partial class Index : System.Web.UI.Page
{
    protected void Button_Click(object sender, EventArgs e)
    {
        var d = new List<double>
        {
            Convert.ToDouble(TextBox1.Text),
            Convert.ToDouble(TextBox2.Text),
            Convert.ToDouble(TextBox3.Text)
        };

        Label.Text = $"Sum: {d.Sum()}";
        Label.Text += $"<br>Average: {d.Average()}";
        Label.Text += $"<br>Max: {d.Min()}";
        Label.Text += $"<br>Min: {d.Min()}<br>";
        d.ForEach(x => Label.Text += $"<br>{x}^2: {x * x}");
        Label.Text += "<br>";
        d.ForEach(x => Label.Text += $"<br> {x} - {d.Average()} = {x - d.Average()}");
    }
}
