using System;

public partial class Index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SphereLabel.Text = "Sphere Volume: ";
        CubeLabel.Text = "Cube Volume: ";
    }

    protected void SphereRadiusBox_TextChanged(object sender, EventArgs e)
    {
        var sphere = new Sphere(double.Parse(SphereRadiusBox.Text));
        SphereLabel.Text += sphere.GetVolume();
    }

    protected void CubeEdgeBox_TextChanged(object sender, EventArgs e)
    {
        var cube = new Cube(double.Parse(SphereRadiusBox.Text));
        SphereLabel.Text = SphereLabel.Text;
        CubeLabel.Text += cube.GetVolume();
    }
}
