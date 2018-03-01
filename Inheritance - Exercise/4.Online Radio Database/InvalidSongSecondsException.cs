using System;
using System.Collections.Generic;
using System.Text;


class InvalidSongSecondsException : InvalidSongLengthException
{
    public InvalidSongSecondsException(int seconds) : base()
    {
        this.Seconds = seconds;

        if (seconds < 0 || seconds > 59)
        {
            throw new ArgumentException("Song seconds should be between 0 and 59.");
        }
    }
}

