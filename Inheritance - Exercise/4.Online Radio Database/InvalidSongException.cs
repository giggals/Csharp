using System;
using System.Collections.Generic;
using System.Text;


public class InvalidSongException
{
    private string artistName;
    private string songname;
    private int seconds;
    private int minutes;
  
        
    public InvalidSongException(string artistName)
    {
        this.ArtistName = artistName;
       
    }

    public InvalidSongException()
    {
        
    }

    public InvalidSongException(int seconds , int minutes )
    {
        this.Seconds = seconds;
        this.Minutes = minutes;
    }

    public InvalidSongException(string artistName, string songName, int minutes, int seconds) : this(artistName) 
    {
        this.SongName = songName;
        this.Minutes = minutes;
        this.Seconds = seconds;
    }
    
    public string ArtistName
    {
        get { return artistName; }
        set
        {
            ChekSongAndArtistNames(value);
            artistName = value;
        }
    }

    public string SongName
    {
        get { return songname; }
        set
        {
            ChekSongAndArtistNames(value);
            songname = value;
        }
    }

    public int Seconds
    {
        get { return seconds; }
        set
        {
            
            seconds = value;
        }
    }


    public int Minutes
    {
        get { return minutes; }
        set
        {
            minutes = value;
        }
    }
    

    private void ChekSongAndArtistNames(string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            throw new ArgumentException("Invalid song.");
        }
    }

    public string AddSong(string songName)
    {
        return $"Song added.";
    }
}
