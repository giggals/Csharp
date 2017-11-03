using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();

            string pattern = @"([^0-9]+)(\d+)";

            StringBuilder result = new StringBuilder();

            foreach (Match m in Regex.Matches(inputLine, pattern, RegexOptions.Multiline))
            {
                var word = m.Groups[1].Value.ToString().ToUpper();
                var counter =int.Parse(m.Groups[2].Value);
                

                for (int i = 0; i < counter; i++)
                {
                    result.Append(word);
                }
            }
            var uniqueSymbols = result.ToString().Distinct().Count();
            Console.WriteLine($"Unique symbols used: {uniqueSymbols}");
            Console.WriteLine(result);
        }
    }
}
