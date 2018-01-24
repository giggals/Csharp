using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = int.Parse(Console.ReadLine());

            Queue<string> tail = new Queue<string>();

            for (long i = 0; i < n; i++)
            {
                tail.Enqueue( Console.ReadLine());
            }

            bool canDoIt = false;

            for (int i = 0; i < n; i++)
            {
                long fuel = 0;
                foreach (var item in tail)
                {
                    fuel += item.Trim().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray()[0];
                    fuel -= item.Trim().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray()[1];

                    if (fuel < 0)
                    {
                        canDoIt = false;
                        break;
                    }
                    else
                    {
                        canDoIt = true;
                    }

                }
               
                if (canDoIt)
                {
                    Console.WriteLine(i);
                    return;
                }
                string helper = tail.Dequeue();
                tail.Enqueue(helper);
            }
            
        }
    }
}
