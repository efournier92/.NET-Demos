using System;
using System.Linq;

public class Person
{
    public string Name { get; set; }
    public decimal Salary { get; set; }

    public Person(string name, decimal salary)
    {
        Name = name;
        Salary = salary;
    }
}

public partial class Index : System.Web.UI.Page
{
    protected void ShowPeopleButton_Click(object sender, EventArgs e)
    {

    }
}