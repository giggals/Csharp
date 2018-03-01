using System;
using System.Collections.Generic;
using System.Text;

class InvalidSongMinutesException : InvalidSongLengthException
{
    public InvalidSongMinutesException(int minutes) : base()
    {
        this.Minutes = minutes;
        ChekMinutes(minutes);
    }

    private static void ChekMinutes(int minutes)
    {
        if (minutes > 14 || minutes < 0)
        {
            throw new ArgumentException("Song minutes should be between 0 and 14.");
        }
    }
}

