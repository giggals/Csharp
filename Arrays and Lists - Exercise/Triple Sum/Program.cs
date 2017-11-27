using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triple_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] array = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            bool Istrue = false;

            for (int i = 0; i < array.Length; i++)
            {
                long a = array[i];

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (a != j)
                    {
                        long b = array[j];
                        long sum = a + b;

                        if (array.Contains(sum))
                        {
                            Console.WriteLine($"{a} + {b} == {sum}");
                            Istrue = true;
                        }
                    }
                   
                }
                if (!Istrue)
                {
                    Console.WriteLine("No");
                    break;
                }
                
            }
        }
    }
}
