using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexMon
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var bojomonRegex = @"([A-Za-z]+)-([A-Za-z])+";
            var didiRegex = @"[^A-Za-z-]+";
           Match twin = Regex.Match(input, bojomonRegex);
            while (input.Length > 0)
            {
                Match didimatch = Regex.Match(input, didiRegex);
                
                if (didimatch.Success)
                {
                    Console.WriteLine(didimatch.Value);

                    input = input.Substring(input.IndexOf(didimatch.Value) + didimatch.Value.Length);
                }
                else
                {
                    break;
                }
                
                Match bojomatch = Regex.Match(input, bojomonRegex);
                    
                if (bojomatch.Success)
                {
                    Console.WriteLine(bojomatch);

                    input = input.Substring(input.IndexOf(bojomatch.Value) + bojomatch.Value.Length);
                }
                else
                {
                    break;
                }
                if (!(didimatch.Success && bojomatch.Success))
                {
                    Console.WriteLine(input);
                }
            }
        }
    }
}

