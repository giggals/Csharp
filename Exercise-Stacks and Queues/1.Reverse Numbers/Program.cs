using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Reverse_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' '.ToString().ToCharArray(),StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Stack<int> numbers = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                numbers.Push(input[i]);
            }
            
            while (numbers.Count > 0)
            {
                Console.Write(numbers.Pop() + " ");
               
            }
            Console.WriteLine();
        }
    }
}
