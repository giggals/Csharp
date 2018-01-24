using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Balanced_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();

           
            if (input.Length % 2 != 0)
            {
                Console.WriteLine("No");
                Environment.Exit(0);
            }
            
                char[] firstPart = new [] { '(', '[', '{' };
                char[] seccondPart = new[] { ')', ']', '}' };

            Stack<char> stack = new Stack<char>();

            foreach (var item in input)
            {
                if (firstPart.Contains(item))
                {
                    stack.Push(item);
                }
                else if (seccondPart.Contains(item))
                {
                    var lastElem = stack.Pop();
                    int openingIndex = Array.IndexOf(firstPart, lastElem);

                    int closing = Array.IndexOf(seccondPart, item);

                    if (openingIndex  != closing)
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }

            }
            if (stack.Any())
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }

           
        }
    }
}
