using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {

            var phonebook = new SortedDictionary<string, string>();
            var comand = Console.ReadLine().Split(' ').ToArray();
            while (comand[0] != "END")
            {
                if (comand[0] == "A")
                    phonebook[comand[1]] = comand[2];
                if (comand[1] == "S")
                {
                    if (phonebook.ContainsKey(comand[1]))
                    {
                        Console.WriteLine($"Contact {comand[1]} -> {phonebook[comand[1]]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {comand[1]} does not exist.");
                    }
                }
                else if (comand[0] == "ListAll")
                    foreach (var item in phonebook)
                        Console.WriteLine($"{item.Key} -> {item.Value}");
                comand = Console.ReadLine().Split(' ').ToArray();
            }
        }
    }
}