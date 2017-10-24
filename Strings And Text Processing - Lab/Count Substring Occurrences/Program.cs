using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Substring_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine().ToLower();
            string word = Console.ReadLine().ToLower();

            int count = 0;
            int index = inputText.IndexOf(word);

            while ( index != -1)
            {
                count++;
                index = inputText.IndexOf(word, index + 1);
            }
            Console.WriteLine(count);
        }
    }
}
