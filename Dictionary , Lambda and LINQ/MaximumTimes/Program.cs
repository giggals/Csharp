using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] word = Console.ReadLine().ToLower().Split().ToArray();
            Dictionary<string, int> dict = new Dictionary<string, int>();

            int max = 0;
            foreach (var w in word)
            {
                if (dict.ContainsKey(w))
                {
                    dict[w]++;
                }
                else
                {
                    dict[w] = 1;
                }
            }
            string key = string.Empty;
            foreach (var e in dict)
            {
                if (e.Value > max)
                {
                    key = e.Key;
                    max = e.Value;
                }
            }
            Console.WriteLine($"{key} --> {max}");


        }
    }
}
