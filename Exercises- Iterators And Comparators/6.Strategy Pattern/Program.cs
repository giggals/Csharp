using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        int peopleCount = int.Parse(Console.ReadLine());
        
        SortedSet<Person> peopleSortedAge = new SortedSet<Person>(new PersonAgeComparer());
        SortedSet<Person> peopleSortedName = new SortedSet<Person>(new PersonNameComparer());

        for (int i = 0; i < peopleCount; i++)
        {
            string[] command = Console.ReadLine().Split();
            string name = command[0];
            int age = int.Parse(command[1]);

            Person person = new Person(name, age);

            peopleSortedAge.Add(person);
            peopleSortedName.Add(person);
        }

        foreach (Person person in peopleSortedName)
        {
            Console.WriteLine(person);
        }

        foreach (var person in peopleSortedAge)
        {
            Console.WriteLine(person);
        }


    }
}

