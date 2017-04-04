using System;
using System.Linq;
using System.Collections.Generic;

public partial class Index : System.Web.UI.Page
{
    protected void ShowButton_Click(object sender, EventArgs e)
    {
        Label.Text = "";
        var salaries = new decimal[] { 48533, 92542, 78541, 34522, 88754 };

        IEnumerable<string> salResults = from salary in salaries
                                         where 40000 <= salary && salary <= 70000
                                         orderby salary descending
                                         select $"<br>{salary:C}";
    }
}