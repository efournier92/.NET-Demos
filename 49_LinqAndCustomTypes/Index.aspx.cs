using System;
using System.Collections.Generic;
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
        var people = new Person[] { new Person("John", 1000000), new Person("Joan", 50000), new Person("Paul", 1000000), new Person("Ringo", 25000)};
        IEnumerable<Person> peopleWithO =
            people.Where(person => person.Name.EndsWith("n")).OrderByDescending(person => person.Salary);
        foreach (var person in peopleWithO)
        {
            Label.Text += $"<br>{person.Name}        {person.Salary:C}";
        }
    }
}