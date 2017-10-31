using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Camera_View
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] index = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string secondInput = Console.ReadLine();
            var m = index[0];
            var n = index[1];

            string pattern = $"\\|\\<(.{{0,{m}}})(.{{0,{n}}})";

            Regex regex = new Regex(pattern);

            Match match = regex.Match(secondInput);

            List <string> results = new List<string>();

            while (secondInput.Length > match.Index + 2 && match.Success)
            {
                string matchToAdd = match.Groups[2].Value;

                if (matchToAdd.Contains("|"))
                {
                    matchToAdd = matchToAdd.Substring(0, matchToAdd.IndexOf("|"));
                }

                if (matchToAdd.Contains("<"))
                {
                    matchToAdd = matchToAdd.Substring(0, matchToAdd.IndexOf("<"));
                }

                results.Add(matchToAdd);

                secondInput = secondInput.Substring(match.Index + 2);
                match = regex.Match(secondInput);
            }
            Console.WriteLine(string.Join(", ", results));
        }
    }
}
