using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' '.ToString().ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int elemToEnque = input[0];
            int elemToDeque = input[1];
            int chekElem = input[2];

            int smallestElement = int.MaxValue;

            int[] inputnumbers = Console.ReadLine().Split(' '.ToString().ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Queue<int> tail = new Queue<int>();


            for (int i = 0; i < elemToEnque; i++)
            {
                tail.Enqueue(inputnumbers[i]);
            }
            for (int i = 0; i < elemToDeque; i++)
            {
                tail.Dequeue();
            }
            foreach (var item in tail)
            {
                if (item < smallestElement)
                {
                    smallestElement = item;
                }
                
            }
            if (!tail.Contains(chekElem) && tail.Count > 0)
            {
                Console.WriteLine(smallestElement);
            }

            if (tail.Contains(chekElem))
            {
                Console.WriteLine("true");
                return;
            }
            else if (tail.Count == 0)
            {
                Console.WriteLine(0);
            }
        }
    }
}
