using System;
using System.Collections.Generic;

public partial class Index : System.Web.UI.Page
{
    protected void PrintButton_Click(object sender, EventArgs e)
    {
        IPrintable per = new Person(NameBox.Text);
        IPrintable book = new Document(TextBox.Text);
        var pr = new List<IPrintable>();
        pr.Add(per);
        pr.Add(book);
        pr.ForEach(x => Label.Text += x.Print());
    }
}