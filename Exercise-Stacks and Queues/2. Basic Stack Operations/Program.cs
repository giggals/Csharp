using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int pushElements = int.Parse(input[0]);
            int popElements = int.Parse(input[1]);
            int chekNumber = int.Parse(input[2]);

            int[] elements = Console.ReadLine().Split(' '.ToString().ToCharArray(),StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Stack<int> stack = new Stack<int>();

            int smallestNumber = int.MaxValue;

            for (int i = 0; i < pushElements; i++)
            {
                stack.Push(elements[i]);
            }
            for (int i = 0; i < popElements; i++)
            {
                stack.Pop();

                if (stack.Count == 0)
                {
                    Console.WriteLine("0");
                    return;
                }
            }
            
            if (stack.Contains(chekNumber))
            {
                Console.WriteLine("true");
            }
            
            else
            {
                foreach (var item in stack)
                {
                    if (item < smallestNumber)
                    {
                        smallestNumber = item;
                    }
                }
                Console.WriteLine(smallestNumber);
            }
           
        }
    }
}
