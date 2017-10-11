using System;
using System.Collections.Generic;
using System.Linq;



class Program
{
    static void Main()
    {
        List<int> num = Console.ReadLine().Split().Select(int.Parse).ToList();
        List<int> even = new List<int>();
        List<int> odd = new List<int>();
        string line = Console.ReadLine();

        while (!(line == "Even" || line == "Odd"))
        {
            var tokens = line.Split();
            var command = tokens[0];

            if (command == "Delete")
            {
                var element = int.Parse(tokens[1]);
                num.RemoveAll(a => a == element);
            }
            else if (command == "Insert")
            {
                var element = int.Parse(tokens[1]);
                var index = int.Parse(tokens[2]);
                num.Insert(index, element);
            }
            line = Console.ReadLine();
        }
        for (int i = 0; i < num.Count; i++)
        {
            if (num[i] % 2 == 0)
            {
                even.Add(num[i]);
            }
            else
            {
                odd.Add(num[i]);
            }
        }
        switch (line)
        {
            case "Even":
                Console.WriteLine(string.Join(" ", even));
                break;
            case "Odd":
                Console.WriteLine(string.Join(" ", odd));
                break;
        }

    }
}
