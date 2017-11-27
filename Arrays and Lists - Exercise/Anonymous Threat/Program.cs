using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
           List<string> elements = Console.ReadLine().Split().ToList();

            List<string> dividedWord = new List<string>();
            var result = elements.Concat(dividedWord);

            string input = Console.ReadLine();
            string concat = "";
            while (input != "3:1")
            {
                string[] commands = input.Split();
                string command = commands[0];
                int startIndex = int.Parse(commands[1]);
                int endIndex = int.Parse(commands[2]);
                input = Console.ReadLine();


                if (startIndex > elements.Count - 1 || startIndex < 0)
                {
                    startIndex = 0;
                }
                else if (endIndex > elements.Count - 1 || endIndex < 0)
                {
                    endIndex = elements.Count - 1;
                }


                switch (command)
                {

                    case "merge":
                          
                        for (int i = startIndex; i <= endIndex ; i++)
                        {
                            concat += elements[i];
                        }
                        for (int i = startIndex; i <= endIndex ; i++)
                        {
                            elements.RemoveAt(startIndex);
                        }
                       
                        elements.Insert(startIndex ,concat);
                        
                        Console.WriteLine(concat);
                        break;
                        
                    case "divide":
                        int index = int.Parse(commands[1]);
                        int parts = int.Parse(commands[2]);

                       
                        int partiones = elements[index].Length / parts;
                        while (elements[index].Length >= partiones)
                        {
                          dividedWord.Add(elements[index].Substring(0 ,partiones));
                           elements[index]= elements[index].Substring(partiones);
                        }

                        break;
                }
            }
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
