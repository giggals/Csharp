using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputText = Console.ReadLine().Split(new char[] { ',', '!', '?', '.', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            List<string> palindrom = new List<string>();

            foreach (var item in inputText)
            {
                bool IsPalindrom = Word(item);
                if (IsPalindrom)
                {
                    palindrom.Add(item);
                }
            }
            palindrom = palindrom.Distinct().OrderBy(x => x).ToList();
            Console.WriteLine(string.Join(", ", palindrom));

        }

        static bool Word(string item)
        {
            string reversed = "";

            for (int i = item.Length - 1; i >= 0; i--)
            {
                reversed = reversed + item[i];
            }
            if (reversed == item)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
