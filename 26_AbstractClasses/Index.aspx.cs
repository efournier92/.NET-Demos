using System;

public partial class Index : System.Web.UI.Page
{
    protected void SphereRadiusBox_TextChanged(object sender, EventArgs e)
    {
        var sphere = new Sphere(double.Parse(SphereRadiusBox.Text));
        SphereLabel.Text = "Sphere Volume: " + sphere.GetVolume();
    }
        
    protected void CubeEdgeBox_TextChanged(object sender, EventArgs e)
    {
        var cube = new Cube(double.Parse(SphereRadiusBox.Text));
        //Label.Text += "<br>Cube Volume: " + cube.GetVolume();
    }
}