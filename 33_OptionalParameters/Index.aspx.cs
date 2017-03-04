using System;
using System.Collections.Generic;

public partial class Index : System.Web.UI.Page
{
    protected void SearchButton_Click(object sender, EventArgs e)
    {
        Label.Text = "";
        var bookList = new List<Book>
        {
            new Book(title: "1984", publicationDate: 1948),
            new Book(title: "On The Road", publicationDate: 1957, type: "Scroll"),
            new Book(title: "Hunger Games", publicationDate: DateTime.Now.Year, type: "eBook")
        };

        var searchResults = bookList.FindAll(book => book.Title.ToLower().Contains(SearchBox.Text.ToLower()));
        searchResults.ForEach(book => Label.Text += book.ToString());
    }
}