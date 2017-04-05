using System;
using System.Linq;
using System.Collections.Generic;

public partial class Index : System.Web.UI.Page
{
    protected void ShowButton_Click(object sender, EventArgs e)
    {
        Label.Text = "";
        IEnumerable<int> scores = new int[] { 90, 62, 72, 75, 96, 99, 98, 10 };
        var goodStudentAverage = (from score in scores where score >= 90 select score).Average();
        Label.Text = $"The average for students with an A is: {goodStudentAverage}";

        var averageStudentCount = scores.Count(grade => 70 <= grade && grade < 80);
        Label.Text += $"<br>There are {averageStudentCount} students with a C";
        var student1 = new List<int> { 90, 89, 92 };
        var student2 = new List<int> { 72, 64, 85 };

        var classList = new List<List<int>>();
        classList.Add(student1);
        classList.Add(student2);

        var avgPerStudent = classList.Select(student => student.Average());

        foreach (var studentAvg in avgPerStudent)
        {
            Label.Text += $"<br>Average Grade = {studentAvg}";
        }

    }
}
