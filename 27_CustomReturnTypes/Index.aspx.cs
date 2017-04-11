using System;

public partial class Index : System.Web.UI.Page
{
    protected void SortButton_Click(object sender, EventArgs e)
    {
        var songs = new string[] { TitleBox1.Text, TitleBox2.Text };
        var songLib = new SongLibrary(songs);
        songLib.SortLibrary();
        Label.Text = songLib.DisplaySongs();
    }
}
