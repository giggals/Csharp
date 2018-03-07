using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        List<Citizen> citizens = new List<Citizen>();
        List<Rebel> rebles = new List<Rebel>();


        for (int i = 0; i < n; i++)
        {
            string[] commandInput = Console.ReadLine().Split(" ");
            if (commandInput.Length == 4)
            {
                string name = commandInput[0];
                int age = int.Parse(commandInput[1]);
                string id = commandInput[2];
                string date = commandInput[3];
                Citizen person = new Citizen(name, age, id, date);
                citizens.Add(person);
            }
            else if (commandInput.Length == 3)
            {
                string name = commandInput[0];
                int age =int.Parse(commandInput[1]);
                string group = commandInput[2];

                Rebel rebel = new Rebel(name, age, group);
                rebles.Add(rebel);
            }
            
        }

        string command = string.Empty;
        int total = 0;
        while ((command = Console.ReadLine()) != "End")
        {
            foreach (var person in citizens)
            {
                if (person.PersonName == command)
                {
                    
                    total += person.BuyFood();
                }
            }
            foreach (var rebel in rebles)
            {
                if (rebel.Name == command)
                {
                    total += rebel.BuyFood();
                }
            }
        }


        Console.WriteLine(total);

        
    }
}

