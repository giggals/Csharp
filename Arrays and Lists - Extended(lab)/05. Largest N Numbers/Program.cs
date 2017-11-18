using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Largest_N_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            
            int n = int.Parse(Console.ReadLine());
            numbers.Sort();
            numbers.Reverse();

            List<int> result = new List<int>();

            for (int i = 0; i < n; i++)
            {
                result.Add(numbers[i]);
            }
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
