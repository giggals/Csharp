﻿using System;


class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        Family family = new Family();

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();
            string inputName = input[0];
            int age = int.Parse(input[1]);


            Person person = new Person(inputName, age);
            family.AddMember(person);
        }
        var oldestMember = family.GetOlderMember();
       
        Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");
    }
}

