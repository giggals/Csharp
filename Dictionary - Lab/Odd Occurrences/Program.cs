using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().ToLower().Split(' ').ToArray();

            var counts = new Dictionary<string, int>();
            foreach (var item in words)
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
            var result = new List<string>();
            foreach (var pairs in counts)
            {
                if (pairs.Value % 2 != 0)
                {
                    result.Add(pairs.Key);
                    
                }
                
            }
            Console.WriteLine(string.Join(", ", result));


        }
    }
}
