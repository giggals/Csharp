using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Dont_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> numbers = Console.ReadLine().Split().Select(long.Parse).ToList();

            long sum = 0;
            
            while (numbers.Count > 0)
            {
               int index = int.Parse(Console.ReadLine());

                long removedEl = 0;

                if (index < 0)
                {
                    removedEl = numbers[0];
                    long lastEl = numbers[numbers.Count - 1];
                    numbers.RemoveAt(0);
                    numbers.Insert(0, lastEl);
                    sum += numbers[0];
                }
                else if (index > numbers.Count - 1)
                {
                    removedEl = numbers[numbers.Count - 1];
                    sum += numbers[numbers.Count - 1];
                    long firstEl = numbers[0];
                    numbers.RemoveAt(numbers.Count - 1);
                    numbers.Add(firstEl);
                }
                else
                {
                    removedEl = numbers[index];
                    sum += numbers[index];
                    numbers.RemoveAt(index);

                }

                IncreaseDecrease(numbers, removedEl);
            }
            Console.WriteLine(sum);
        }

        private static List<long> IncreaseDecrease(List<long> numbers, long removedEl)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] <= removedEl)
                { 
                    numbers[i] += removedEl;

                }
                else
                {
                    numbers[i] -= removedEl;
                }
            }
            return numbers;
        }
    }
}
