using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int startIndex = int.Parse(Console.ReadLine());

            Queue<string> queue = new Queue<string>(input);


            while (queue.Count > 1)
            {
                for (int i = 0; i < startIndex - 1; i++)
                {
                    string reminder = queue.Dequeue();
                    queue.Enqueue(reminder);
                }
                Console.WriteLine($"Removed {queue.Dequeue()}");
            }
            Console.WriteLine($"Last is {queue.Peek()}");
        }
    }
}
