using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Numbers_at_Odd_Positions
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int index = 0;

            for (int i = 0; i < numbers.Length ; i++)
            {
                 index++;
                
                    if (i % 2 != 0 && numbers[i] % 2 != 0)
                    {
                        Console.WriteLine($"Index {index - 1} -> {numbers[i]}");
                    }
                
            }
        }
    }
}
