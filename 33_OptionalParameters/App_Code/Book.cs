public class Book
{
    public string Title { get; set; }
    string bookType;
    int pubDate;

    public Book(string title, int publicationDate, string type = "Papery Book")
    {
        Title = title;
        pubDate = publicationDate;
        bookType = type;
    }

    public override string ToString()
    {
        return "Title: " + Title + "<br>Type: " + bookType + "<br>Publication Date: " + pubDate;
    }
}
