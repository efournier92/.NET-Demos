using System;
using System.Web.UI.WebControls;

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
            if (value >= 0)
            {
                _radius = value;
            }
            else
            {
                _radius = 0;
            }
        }
    }
}

public partial class Index : System.Web.UI.Page
{
    protected void TextBox_TextChanged(object sender, EventArgs e)
    {
        var circ = new Circle();
        circ.Radius = double.Parse(TextBox.Text);
    }
}