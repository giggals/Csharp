using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            var counts = new SortedDictionary<double, int>();

            foreach (var item in input)
            {
                if (counts.ContainsKey(item))

                {
                   counts[item]++; 
                }
                else
                {
                    counts[item] = 1;
                }
            }
            foreach (var items in counts.Keys)
            {
                Console.WriteLine($"{items} -> {counts[items]}");
            }
        }
    }
}
