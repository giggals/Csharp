using System;
using System.Collections.Generic;
using System.Text;


public class InvalidSongLengthException : InvalidSongException
{
    public InvalidSongLengthException()
    {

    }

    public InvalidSongLengthException(int seconds , int minutes) : base(seconds , minutes)
    {
        this.Seconds = seconds;
        this.Minutes = minutes;
        ValidateLenght(seconds, minutes);
    }

    private static void ValidateLenght(int seconds, int minutes)
    {
        if ((seconds < 0 || seconds > 59) && minutes > 14)
        {
            throw new ArgumentException("Invalid song length.");
        }
    }
}

