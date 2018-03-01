using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<InvalidSongException> list = new List<InvalidSongException>();
        int numberOFSongs = int.Parse(Console.ReadLine());

        Validations(numberOFSongs, list);


        Console.WriteLine($"Songs added: {list.Count}");
        PrintPlaylistLenght(list);

    }

    private static void PrintPlaylistLenght(List<InvalidSongException> list)
    {
        double secondsSum = 0;
        double minutesSum = 0;
        double hourSum = 0;
        foreach (var item in list)
        {

            if (secondsSum + item.Seconds >= 60)
            {
                minutesSum++;
                secondsSum -= 60;
            }

            if (minutesSum + item.Minutes >= 60)
            {
                hourSum++;
                minutesSum -= 60;
            }
            secondsSum += item.Seconds;
            minutesSum += item.Minutes;

        }
        Console.WriteLine($"Playlist length: {hourSum}h {minutesSum}m {secondsSum}s");
    }

    private static void Validations(int numberOFSongs, List<InvalidSongException> list)
    {
        for (int i = 0; i < numberOFSongs; i++)
        {
            try
            {
                string[] commadInput = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
                string artist = commadInput[0];
                string songName = commadInput[1];
                string songLenght = commadInput[2];
                string[] parsedSongLennght = songLenght.ToString().Split(":", StringSplitOptions.RemoveEmptyEntries).ToArray();
                int minutse = int.Parse(parsedSongLennght[0]);
                int seconds = int.Parse(parsedSongLennght[1]);
                InvalidSongException chekSong = new InvalidSongException(artist, songName, minutse, seconds);
                InvalidArtistNameException chekArtist = new InvalidArtistNameException(artist);
                InvalidSongNameException chekSongName = new InvalidSongNameException(songName);
                try
                {
                    InvalidSongLengthException chekLenght = new InvalidSongLengthException(seconds, minutse);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                InvalidSongMinutesException chekMin = new InvalidSongMinutesException(minutse);
                InvalidSongSecondsException chekSeconds = new InvalidSongSecondsException(seconds);

                Console.WriteLine(chekSong.AddSong(songName));
                list.Add(chekSong);

            }
            catch (ArgumentException argex)
            {
                Console.WriteLine(argex.Message);
            }
        }

    }

}

