using System;
using System.Collections.Generic;

public partial class Index : System.Web.UI.Page
{
    protected void PrintButton_Click(object sender, EventArgs e)
    {
        IPrintable per = new Person(NameBox.Text);
        IPrintable book = new Document(QuoteBox.Text);
        var pr = new List<IPrintable> { per, book };
        pr.ForEach(x => Label.Text += x.Print());
    }
}
