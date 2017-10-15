using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fold__and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            

            int k = input.Length / 4;


            var leftrow1 = input.Take(k).Reverse();
            var rightrow1 = input.Reverse().Take(k);
            var row2 = input.Skip(k).Take(2 * k).ToArray();
            var row1 = leftrow1.Concat(rightrow1).ToArray();

            var sum = row1.Select((x, index) => x + row2[index]);

            Console.WriteLine(string.Join(" ", sum));
            
        }
    }
}
