using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        string command = string.Empty;
        ListyIterator<string> listyIterator = new ListyIterator<string>();

        while ((command = Console.ReadLine()) != "END")
        {

            try
            {
                string[] commandArgs = command.Split();

                switch (commandArgs[0])
                {
                    case "Create":
                        if (commandArgs.Length == 1)
                        {
                            listyIterator.Create();
                        }

                        listyIterator.Create(commandArgs.Skip(1).ToArray());
                        break;
                    case "Move":
                        Console.WriteLine(listyIterator.Move());
                        break;
                    case "HasNext":
                        Console.WriteLine(listyIterator.HasNext());
                        break;
                    case "Print":
                        listyIterator.Print();
                        break;
                    case "PrintAll":
                        listyIterator.PrintAll();
                        break;
                }
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
                
            }
            
        }
    }
}

