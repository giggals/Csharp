using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Magic_exchangeable_words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            string word1 = input[0];
            string word2 = input[1];

            var arr1 = word1.ToCharArray().Distinct().ToArray();
            var arr2 = word2.ToCharArray().Distinct().ToArray();

           

            if (arr1.Length == arr2.Length)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false    ");
            }
        }
    }
}
