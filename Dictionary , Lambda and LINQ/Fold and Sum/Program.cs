using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int k = numbers.Length / 4;

            var leftpart1 = numbers.Take(k).Reverse();
            var rightpart2 = numbers.Reverse().Take(k);

            var concat = leftpart1.Concat(rightpart2).ToArray();

            var row2 = numbers.Skip(k).Take(2 * k).ToArray();

            var sum = concat.Select((x, index) => x + row2[index]);
            Console.WriteLine(string.Join(" ",sum));
        }
    }
}
