using System;
using System.Linq;
using System.Collections.Generic;

public class Student
{
    public string Name { get; set; }
    public List<int> Grades;
}

public partial class Index : System.Web.UI.Page
{
    protected void ShowResults_Click(object sender, EventArgs e)
    {
        Label.Text = "";

        var students = new List<Student>
        {
            new Student {Name = "Lennon, John", Grades = new List<int> {87, 91, 76, 88}},
            new Student {Name = "Starr, Ringo", Grades = new List<int> {66, 71, 85, 74}},
            new Student {Name = "Lennon, Sean", Grades = new List<int> {91, 95, 89, 92}}
        };
        var groupsByFirstLetters = from student in students
                                   group student by student.Name[0];
        foreach (var studentGroup in groupsByFirstLetters)
        {
            Label.Text += $"<br><b>{studentGroup.Key}</b>";
            foreach (var st in studentGroup)
            {
                Label.Text += $"<br>{st.Name}";
            }
            Label.Text += "<hr>";
        }
    }
}