using System;

public class Circle // a template for making circle objects
{
    private double _radius;

    public double Radius
    {
        get
        {
            return _radius;
        }
        set
        {
            _radius = value >= 0 ? value : 0;
        }
    }
}

public partial class Index : System.Web.UI.Page
{
    protected void TextBox_TextChanged(object sender, EventArgs e)
    {
        var circ = new Circle { Radius = double.Parse(TextBox.Text) };
        Label.Text = $"Circumference: {2 * Math.PI * circ.Radius}";
    }
}
