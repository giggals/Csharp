using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        List<Person> people = new List<Person>();

        string command = string.Empty;

        while ((command = Console.ReadLine()) != "END")
        {
            string[] commandArgs = command.Split();

            string name = commandArgs[0];
            int age = int.Parse(commandArgs[1]);
            string town = commandArgs[2];

            Person person = new Person(name ,age ,town);
            people.Add(person);
        }

        int chekAtIndex = int.Parse(Console.ReadLine()) - 1;

        int counter = 0;
        foreach (var person in people)
        {
            if (people[chekAtIndex].CompareTo(person) == 0)
            {
                counter++;
            }
        }

        if (counter > 1)
        {
            Console.WriteLine($"{counter} {people.Count - counter} {people.Count}");
        }
        else
        {
            Console.WriteLine("No matches");
        }

        
    }
}

