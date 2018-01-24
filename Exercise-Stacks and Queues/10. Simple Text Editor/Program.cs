using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfOperations = int.Parse(Console.ReadLine());


            var text = new StringBuilder();
            Stack<string> undone = new Stack<string>();
            undone.Push("");
                
            for (int i = 0; i < numberOfOperations; i++)
            {
                string[] Inputcommands = Console.ReadLine().Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries);
                int command = int.Parse(Inputcommands[0]);

                if (command == 1)
                {
                    undone.Push(text.ToString());
                    string inputText =Inputcommands[1];
                    
                        text.Append(inputText);
                   
                }
                else if (command == 2)
                {
                    undone.Push(text.ToString());
                    int erease = int.Parse(Inputcommands[1]);
                    
                    text.Remove(text.Length - erease,erease);
                   
                }
                else if (command == 3)
                {
                    int retrunIndex = int.Parse(Inputcommands[1]);

                    Console.WriteLine(text[retrunIndex - 1]);
                   
                }
                else if (command == 4)
                {
                    text.Clear();
                    text.Append(undone.Pop());
                }
            }
        }
    }
}
