using System;


public class Program
{
    static void Main(string[] args)
    {
        CustomList<string> list = new CustomList<string>();

        string command = string.Empty;

        while ((command = Console.ReadLine()) != "END")
        {
            var commandArgs = command.Split();


            switch (commandArgs[0])
            {
                case "Add":
                    list.Add((commandArgs[1]));
                    break;
                case "Remove":
                    list.Remove(int.Parse(commandArgs[1]));
                    break;
                case "Contains":
                    var containts = list.Contains((commandArgs[1]));
                    var result = containts ? "True" : "False";
                    Console.WriteLine(result);
                    break;
                case "Swap":
                    list.Swap(int.Parse(commandArgs[1]), int.Parse(commandArgs[2]));
                    break;
                case "Greater":
                    Console.WriteLine(list.CountGreaterThan((commandArgs[1])));
                    break;
                case "Max":
                    Console.WriteLine(list.Max());
                    break;
                case "Min":
                    Console.WriteLine(list.Min());
                    break;
                case "Print":
                    foreach (var item in list.list)
                    {
                        Console.WriteLine(item);
                    }
                    break;
                case "Sort":
                    list.Sort();
                    break;

            }
        }

    }
}

