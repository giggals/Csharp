using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> squareNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            var result = new List<int>();

            foreach (var x in squareNumbers)
            {
                if (Math.Sqrt(x) == (int)Math.Sqrt(x))
                {
                    result.Add(x);
                }

            }
            result.Sort();
            result.Reverse();
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
