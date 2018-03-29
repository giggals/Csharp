using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        int peopleCount = int.Parse(Console.ReadLine());

        SortedSet<Person> sorted = new SortedSet<Person>();
        HashSet<Person> hashSet = new HashSet<Person>();

        for (int i = 0; i < peopleCount; i++)
        {
            string[] command = Console.ReadLine().Split();
            string name = command[0];
            int age = int.Parse(command[1]);


            Person person = new Person(name ,age);

            sorted.Add(person);
            hashSet.Add(person);

        }

        Console.WriteLine(sorted.Count);
        Console.WriteLine(hashSet.Count);
    }
}

