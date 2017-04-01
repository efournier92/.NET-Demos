using System;
using System.Linq;
using System.Collections.Generic;

public partial class Index : System.Web.UI.Page
{
    protected void ShowValuesButton_Click(object sender, EventArgs e)
    {
        IEnumerable<string> names = new string[] { "John", "Paul", "George", "Ringo", "Bob", "Dylan" };
        List<int> lst = new int[] { 1, 2, -7, 11, 33, 42, -10, 55 }.ToList();
        IEnumerable<int> valuesMoreThanTen = lst.Where(x => x > 10);
        valuesMoreThanTen.ToList().ForEach(x => Label.Text += $"<br>x={x}");
    }
}