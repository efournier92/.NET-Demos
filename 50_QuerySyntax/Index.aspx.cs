using System;
using System.Linq;
using System.Collections.Generic;

public partial class Index : System.Web.UI.Page
{
    protected void ShowButton_Click(object sender, EventArgs e)
    {
        Label.Text = "";
        var salaries = new decimal[] { 48533, 92542, 78541, 34522, 88754 };

        var salResults = from salary in salaries
                                         where 20000 <= salary && salary <= 80000
                                         orderby salary descending
                                         select $"<br>{salary:C}";

        foreach (var salary in salResults)
        {
            Label.Text += $"<br>{salary:C}";
        }
        Label.Text += "<br><hr>";

        var nameSalaries = new Dictionary<string, decimal>
        {
            {"Steve Jobs", 4900000},
            {"Steve Wozniak", 5000000},
            {"Steve Bannon", 45000},
            {"Ringo Starr", 99000}
        };

        var dictResults = from nameSalary in nameSalaries
                                          where nameSalary.Key.Contains("Steve") && nameSalary.Value >= 1000000
                                          select $"<br>{nameSalary.Key} earns {nameSalary.Value:C} per year.";

        foreach (var nameSal in dictResults)
        {
            Label.Text += nameSal;
        }
        Label.Text += "<br><br><hr>";
    }
}
