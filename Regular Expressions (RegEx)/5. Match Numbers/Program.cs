using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05.Match_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputNumbers = Console.ReadLine();
            string pattern = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";

            MatchCollection matches = Regex.Matches(inputNumbers, pattern);

            foreach (Match number in matches)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}
