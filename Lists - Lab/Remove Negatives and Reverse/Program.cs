using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split(' ')
            .Select(int.Parse)
            .Reverse()
                .ToList();

            var result = new List<int>();

            foreach (var x in input)
            {
                if (x < 0)
                {
                    result.Remove(x);
                   
                }
                else if(x > 0)
                {
                    Console.WriteLine(String.Join(" ", x));
                    Console.WriteLine();
                }
               

            }
        }
    }
}
