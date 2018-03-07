using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {

        try
        {
            List<Private> privates = new List<Private>();

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] commandARgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string soldierType = commandARgs[0];
                ParseCommands(privates, commandARgs, soldierType);
            }
        }

        catch (ArgumentException ex)
        {
            
        }
       
    }

    private static void ParseCommands(List<Private> privates, string[] commandARgs, string soldierType)
    {
        switch (soldierType)
        {
            case "Private":
                Soldier privateSoldier = new Private(int.Parse(commandARgs[1]),
                   commandARgs[2], commandARgs[3], decimal.Parse(commandARgs[4]));
                privates.Add((Private)privateSoldier);
                Console.WriteLine(privateSoldier);
                break;
            case "Spy":
                Spy spy = new Spy(int.Parse(commandARgs[1]), commandARgs[2], (commandARgs[3]), int.Parse(commandARgs[4]));
                Console.WriteLine(spy);
                break;
            case "LeutenantGeneral":
                Soldier leutenantGeneral = new LeutenantGeneral(int.Parse(commandARgs[1]), commandARgs[2], commandARgs[3], decimal.Parse(commandARgs[4]));
                Console.WriteLine(leutenantGeneral);
                for (int i = privates.Count - 1; i >= 0; i--)
                {
                    Console.WriteLine($"  {privates[i]}");
                }
                break;
            case "Commando":
                if (commandARgs.Length == 6)
                {
                    Soldier commando = new Commando(int.Parse(commandARgs[1]), commandARgs[2], commandARgs[3], decimal.Parse(commandARgs[4]), commandARgs[5]);
                    Console.WriteLine(commando);
                }
                else
                {
                    Soldier commando = new Commando(int.Parse(commandARgs[1]), commandARgs[2], commandARgs[3], decimal.Parse(commandARgs[4]), commandARgs[5], commandARgs[commandARgs.Length - 2], commandARgs[commandARgs.Length - 1]);
                    Console.WriteLine(commando);
                }
                break;
            case "Engineer":
                int id = int.Parse(commandARgs[1]);
                var firstName = commandARgs[2];
                var lastName = commandARgs[3];
                decimal salary = decimal.Parse(commandARgs[4]);
                string corps = commandARgs[5];

                if (commandARgs.Length == 6)
                {
                    Engineer engineer = new Engineer(firstName, lastName, id, salary, corps);
                    Console.WriteLine(engineer);
                }
                else
                {
                    List<Engineer> engineers = new List<Engineer>();
                    for (int i = 6; i < commandARgs.Length; i += 2)
                    {
                        string partName = commandARgs[i];
                        int hourseWorked = int.Parse(commandARgs[i + 1]);
                        Engineer engineer = new Engineer(firstName, lastName, id, salary, corps, partName, hourseWorked);
                        engineers.Add(engineer);
                        engineer.AddToDict(partName, hourseWorked);
                    }
                    Console.WriteLine(engineers.First());
                    foreach (var item in engineers)
                    {
                        Console.WriteLine($"  Part Name: {item.PartName} Hours Worked: {item.HouresWorked}");
                    }
                }
                break;


        }
    }
}

