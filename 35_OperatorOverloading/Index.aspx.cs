using System;

public partial class Index : System.Web.UI.Page
{
    protected void AddButton_Click(object sender, EventArgs e)
    {
        var vec1 = new Vector(1, 2);
        var vec2 = new Vector(3, 4);
        var vec3 = new Vector(5, 6);
        var vecs = new[] { vec1, vec2, vec3 };
        Label.Text = "";

        foreach (var v1 in vecs)
        {
            foreach (var v2 in vecs)
            {
                Label.Text += "<br>" + v1 + " + " + v2 + " = " + (v1 + v2);
            }
        }
    }
}
