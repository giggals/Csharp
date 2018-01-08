﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Math_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int startIndex = int.Parse(Console.ReadLine());

            Queue<string> queue = new Queue<string>(input);

            int cycle = 1;
            while (queue.Count > 1)
            {
                for (int i = 0; i < startIndex - 1; i++)
                {
                    string reminder = queue.Dequeue();
                    queue.Enqueue(reminder);

                }

                if (PrimeTool.IsPrime(cycle))
                {
                    Console.WriteLine($"Prime {queue.Peek()}");
                }
                else
                {
                    Console.WriteLine($"Removed {queue.Dequeue()}");
                }
                cycle++;
                
            }
            Console.WriteLine($"Last is {queue.Peek()}");
        }

        public static class PrimeTool
        {
            public static bool IsPrime(int candidate)
            {

                if ((candidate & 1) == 0)
                {
                    if (candidate == 2)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

                for (int i = 3; (i * i) <= candidate; i += 2)
                {
                    if ((candidate % i) == 0)
                    {
                        return false;
                    }
                }
                return candidate != 1;
            }
        }
    }
}
