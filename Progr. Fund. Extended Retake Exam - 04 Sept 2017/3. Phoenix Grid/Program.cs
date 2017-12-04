using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _3.Phoenix_Grid
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var pattern = new Regex (@"^([^_\s]{3})(\.[^_\s]{3})*$");
            

            while (input != "ReadMe")
            {
                if (pattern.IsMatch(input))
                {
                    if (IsPalindrome(input))
                    {
                        Console.WriteLine("YES");
                    }
                    else
                    {
                        Console.WriteLine("NO");
                    }

                }
                else
                {
                    Console.WriteLine("NO");
                }


                input = Console.ReadLine();

            }
        }

        static bool IsPalindrome(string word)
        {

            int length = word.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (word[i] != word[length - i - 1])
                    return false;
            }
            return true;
        }
    }
}
