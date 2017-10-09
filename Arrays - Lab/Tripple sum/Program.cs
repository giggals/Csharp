using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tripple_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] arr = input.Split(' ');

            long[] numbers = arr.Select(long.Parse).ToArray();
            bool isAny = false;

            for (int i = 0; i < numbers.Length ; i++)
            {
                long a = numbers[i];

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (i != j)
                    {
                        long b = numbers[j];
                        long sum = a + b;
                        if (numbers.Contains(sum))
                        {
                            Console.WriteLine($"{a} + {b} == {sum}");
                            isAny = true;
                        }
                    }
                }
                if (!isAny)
                {
                    Console.WriteLine("No");
                    break;
                }

            }
        }
    }
}
