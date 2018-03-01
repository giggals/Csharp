using System;
using System.Collections.Generic;
using System.Text;


public class InvalidArtistNameException : InvalidSongException
{
    public InvalidArtistNameException(string name) : base (name)
    {
        NameValidations(name);
       
    }

    private static void NameValidations(string name)
    {
        if (name.Length < 3 || name.Length > 20)
        {
            throw new ArgumentException($"Artist name should be between 3 and 20 symbols.");
        }
    }
}

