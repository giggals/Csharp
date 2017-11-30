using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            var result = numbers.OrderByDescending(p => p).Take(3);

            Console.WriteLine(string.Join(" ",result));
        }
    }
}
