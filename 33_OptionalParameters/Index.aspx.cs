using System;
using System.Collections.Generic;

public partial class Index : System.Web.UI.Page
{
    protected void SearchButton_Click(object sender, EventArgs e)
    {
        Label.Text = "";
        var bookList = new List<Book>();
        bookList.Add(new Book(title: "1984", publicationDate: 1948));
        bookList.Add(new Book(title: "On The Road", publicationDate: 1957, type: "Scroll"));
        bookList.Add(new Book(title: "Hunger Games", publicationDate: 2008, type: "Digital Book"));
    }
}