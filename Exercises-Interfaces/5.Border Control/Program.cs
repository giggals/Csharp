using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<Society> society = new List<Society>();

        SaparateSociety(society);
        PrintResult(society);
    }

    private static void SaparateSociety(List<Society> society)
    {
        string command = string.Empty;
        while ((command = Console.ReadLine()) != "End")
        {
            string[] inputArgs = command.Split();
            if (inputArgs.Length == 3)
            {
                string personName = inputArgs[0];
                int age = int.Parse(inputArgs[1]);
                string id = inputArgs[2];

                ICitizens person = new Society(personName, age, id);
                society.Add((Society)person);
               
            }
            else if (inputArgs.Length == 2)
            {
                string robotName = inputArgs[0];
                string id = inputArgs[1];

                IRobots robot = new Society(robotName, id);
                society.Add((Society)robot);
            }
        }
    }

    private static void PrintResult(List<Society> society)
    {
        string chekId = Console.ReadLine();

        foreach (var s in society)
        {
            if (!string.IsNullOrEmpty(s.IdPerson) && s.IdPerson.EndsWith(chekId))
            {
                Console.WriteLine(s.IdPerson);
            }
           else if (!string.IsNullOrEmpty(s.IdRobot) && s.IdRobot.EndsWith(chekId))
            {
                Console.WriteLine(s.IdRobot);
            }

        }
        

    }
}

