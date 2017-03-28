using System;
using System.Collections.Generic;

public partial class Index : System.Web.UI.Page
{

    protected void FormatButton_Click(object sender, EventArgs e)
    {
        List<Product> lp = new List<Product>();
        lp.Add(new Book(BookTitleBox.Text, decimal.Parse(BookPriceBox.Text)));
        lp.Add(new Shoe(ShoeMakeBox.Text, decimal.Parse(ShoePriceBox.Text)));
        lp.ForEach(x => Label.Text += "<br>" + x.GetDesc());
    }
}