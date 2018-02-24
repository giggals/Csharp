using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        List<Person> personList = new List<Person>();

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string name = input[0];
            int age = int.Parse(input[1]);

            Person person = new Person(name, age);

            if (person.Age > 30)
            {
                personList.Add(person);
            }

        }
        foreach (var item in personList.OrderBy(x => x.Name))
        {
            Console.WriteLine($"{item.Name} - {item.Age}");
        }
    }
}

