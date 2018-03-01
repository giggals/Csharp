using System;
using System.Collections.Generic;
using System.Text;


public class InvalidSongNameException : InvalidSongException
{
    public InvalidSongNameException(string songName)
    {
        this.SongName = songName;
        SongNameValidation();
    }

    private void SongNameValidation()
    {
        if (this.SongName.Length < 3 || this.SongName.Length > 30)
        {
            throw new ArgumentException("Song name should be between 3 and 30 symbols.");
        }
    }
}

