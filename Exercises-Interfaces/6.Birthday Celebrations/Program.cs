using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        string command = string.Empty;
        List<string> dates = new List<string>();
        
        while ((command = Console.ReadLine()) != "End")
        {
            ParseCommand(command, dates);
        }

        string chekDate = Console.ReadLine();
        PrintResult(dates, chekDate);

    }

    private static void PrintResult(List<string> dates, string chekDate)
    {
        List<string> resutlList = new List<string>();

        foreach (var date in dates)
        {
            if (date.EndsWith(chekDate))
            {
                resutlList.Add(date);
            }

        }

        if (resutlList.Count == 0)
        {
            Console.WriteLine();
        }
        else
        {
            foreach (var date in resutlList)
            {
                Console.WriteLine(date);
            }
        }
    }

    private static void ParseCommand(string command, List<string> dates)
    {
        string[] parsedCommand = command.Split();

        switch (parsedCommand[0])
        {
            case "Citizen":
                string name = parsedCommand[1];
                int age = int.Parse(parsedCommand[2]);
                string id = parsedCommand[3];
                string personBirthday = parsedCommand[4];
                ICitizens person = new Society(name, age, id, personBirthday);
                dates.Add(person.BirthDate);

                break;
            case "Pet":
                string petName = parsedCommand[1];
                string petBirthday = parsedCommand[2];
                Pet pet = new Pet(petName, petBirthday);
                dates.Add(pet.BirthDay);

                break;
            case "Robot":
                string model = parsedCommand[1];
                string robotId = parsedCommand[2];
                break;
        }
    }
}

