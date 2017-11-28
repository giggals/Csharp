using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Anonymous_Vox
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] values = Console.ReadLine().Split("{}".ToCharArray(),StringSplitOptions.RemoveEmptyEntries);

            string pattern = @"([A-Za-z]+)(.+)(\1)";
            
            MatchCollection matches = Regex.Matches(text, pattern);
            
            int count = 0;
            foreach (Match m in matches)
            {
                if (count == values.Length)
                {
                    break;
                }
                var placeholder = m.Groups[2];
               
                    text = text.Replace(placeholder.Value, values[count++]);
               
            }
            Console.WriteLine(text);
        }
    }
}
