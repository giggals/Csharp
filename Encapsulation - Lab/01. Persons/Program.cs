using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        var persons = new List<Person>();

        for (int i = 0; i < n; i++)
        {
            string[] inputArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var person = new Person(inputArgs[0], inputArgs[1], int.Parse(inputArgs[2]));
            persons.Add(person);
        }

        persons.OrderBy(p => p.FirstName).ThenBy(a => a.Age)
            .ToList()
            .ForEach(p => Console.WriteLine(p.ToString()));
    }
}

