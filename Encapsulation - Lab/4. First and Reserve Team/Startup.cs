using System;
using System.Collections.Generic;


public class StartUp
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string teamname = "Real Madrid";
        Team team = new Team(teamname);

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();
            string firstName = input[0];
            string lastName = input[1];
            int age = int.Parse(input[2]);
            decimal salary = decimal.Parse(input[3]);

            var person = new Person(firstName, lastName, age, salary);
            team.AddPlayers(person);

        }

        Console.WriteLine($"First team has {team.FirstTeam.Count} players.");
        Console.WriteLine($"Reserve team has {team.ReserveTeam.Count} players.");
    }
}

