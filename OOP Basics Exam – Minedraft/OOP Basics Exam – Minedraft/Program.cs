using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string[] commandArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        
        DraftManager draftManager = new DraftManager();
        
        while (commandArgs[0] != "Shutdown")
        {
            List<string> arguments = new List<string>();
            switch (commandArgs[0])
            {
                case "RegisterHarvester":
                    
                    string type = commandArgs[1];
                    string id = commandArgs[2];
                    double oreOutput = double.Parse(commandArgs[3]);
                    double energyRequirement = double.Parse(commandArgs[4]);

                    arguments.Add(type);
                    arguments.Add(id);
                    arguments.Add(oreOutput.ToString());
                    arguments.Add(energyRequirement.ToString());

                    if (type == "Sonic")
                    {
                        int sonicFactor = int.Parse(commandArgs[5]);
                        arguments.Add(sonicFactor.ToString());
                    }
                    Console.WriteLine(draftManager.RegisterHarvester(arguments));
                    break;
                case "RegisterProvider":
                     type = commandArgs[1];

                     id = commandArgs[2];

                     energyRequirement = double.Parse(commandArgs[3]);
                    arguments.Add(type);
                    arguments.Add(id);
                    arguments.Add(energyRequirement.ToString());

                    Console.WriteLine(draftManager.RegisterProvider(arguments));
                    break;
                case "Day":
                    Console.WriteLine(draftManager.Day());
                    break;
                case "Check":
                    var idToChek = commandArgs[1];
                    arguments.Add(idToChek);
                    Console.WriteLine(draftManager.Chek(arguments));
                    break;
                case "Mode":
                    string mode = commandArgs[1];
                    arguments.Add(mode);
                    Console.WriteLine(draftManager.Mode(arguments));
                    break;
            }
            commandArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        }

        Console.WriteLine(draftManager.ShutDown());
        
    }
    
}

