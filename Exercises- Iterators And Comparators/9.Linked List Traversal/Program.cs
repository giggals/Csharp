using System;


class Program
{
    static void Main(string[] args)
    {
        int commandsCount = int.Parse(Console.ReadLine());

        LinkedListTraversal<int> linkedList = new LinkedListTraversal<int>();
        
        for (int i = 0; i < commandsCount; i++)
        {
            string[] commandInput = Console.ReadLine().Split();

            switch (commandInput[0])
            {
                case "Add":
                    linkedList.Add(int.Parse(commandInput[1]));
                    break;
                case "Remove":
                    linkedList.Remove(int.Parse(commandInput[1]));
                    break;
            }

        }

        Console.WriteLine(linkedList.Count);

        foreach (var i in linkedList)
        {
            Console.Write(i + " ");
        }

        Console.WriteLine();
    }
}

