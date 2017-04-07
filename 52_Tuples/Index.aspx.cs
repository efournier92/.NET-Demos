using System;
using System.Collections.Generic;
using System.Linq;

public partial class Index : System.Web.UI.Page
{
    private static Tuple<double, double, double, double> SummarizeList(IReadOnlyCollection<double> listDoubles)
    {
        var summary = Tuple.Create(
            listDoubles.Sum(),
            listDoubles.Average(),
            listDoubles.Max(),
            listDoubles.Min());
        return summary;
    }

    protected void ShowTupleButton_Click(object sender, EventArgs e)
    {
        var lst = new List<double> { 3, 2, 5, 92, 76, -9, 0.5432, 98.9, 2 };
        var results = SummarizeList(lst);
        Label.Text = $"<br>Sum = {results.Item1}";
        Label.Text += $"<br>Average = {results.Item2}";
        Label.Text += $"<br>Max = {results.Item3}";
        Label.Text += $"<br>Min = {results.Item4}";
    }
}