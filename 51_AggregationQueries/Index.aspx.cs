using System;
using System.Linq;
using System.Collections.Generic;

public partial class Index : System.Web.UI.Page
{
    protected void Button1_Click(object sender, EventArgs e)
    {
        IEnumerable<int> scores = new int[] { 88, 62, 42, 55, 69, 99, 98, 10 };
        var goodStudentAverage = (from score in scores where score >= 90 select score).Average();
        Label
    }
}
