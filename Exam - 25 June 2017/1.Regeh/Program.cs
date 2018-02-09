using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _1.Regeh
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"\[[a-zA-Z]+<(\d+)REGEH(\d+)>[a-zA-Z]+\]";

            MatchCollection matches = Regex.Matches(input, pattern);

            int currentIndex = 0;

            List<int> indexes = new List<int>();

            foreach (Match item in matches)
            {
                int firstindex = int.Parse(item.Groups[1].Value);
               int  secondindex = int.Parse(item.Groups[2].Value);

                currentIndex += firstindex;

                indexes.Add(currentIndex);
                currentIndex += secondindex;
                indexes.Add(currentIndex);
            }

            for (int i = 0; i < indexes.Count; i++)
            {
                if (indexes[i] > input.Length)
                {
                    indexes[i] = 0;
                }
                Console.Write(input[indexes[i]]);
            }
            
        }
    }
}
