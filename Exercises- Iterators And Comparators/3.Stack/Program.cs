using System;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        string command = string.Empty;

        Stack<string> stack = new Stack<string>();

        while ((command = Console.ReadLine()) != "END")
        {
            try
            {
                string[] commandArgs = command.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

                switch (commandArgs[0])
                {
                    case "Push":
                        stack.Push(commandArgs.Skip(1).ToArray());
                        break;
                    case "Pop":
                        stack.Pop();
                        break;
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

        }

        for (int i = 0; i < 2; i++)
        {
            foreach (var item in stack)
            {
                Console.WriteLine(item.ToString());
            }
        }

    }
}

