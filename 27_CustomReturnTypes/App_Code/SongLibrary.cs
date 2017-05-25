using System;
using System.Linq;

public class SongLibrary
{
    private readonly string[] _songs;
    public SongLibrary(string[] tunes)
    {
        _songs = tunes;
    }

    public SongLibrary SortLibrary()
    {
        Array.Sort(_songs);
        return this;
    }

    public string DisplaySongs()
    {
        return _songs.Aggregate<string, string>(
            null, (current, str) => current + ($"<br> {str}")
        );
    }
}
