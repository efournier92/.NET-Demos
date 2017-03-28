using System;

public class SongLibrary
{
    private string[] songs;
    public SongLibrary(string[] tunes)
    {
        songs = tunes;
    }

    public SongLibrary SortLibrary()
    {
        Array.Sort(songs);
        return this;
    }

    public string DisplaySongs()
    {
        string list = null;
        foreach (var str in songs)
        {
            list += "<br>" + str;
        }
        return list; 
    }
}