using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(
             ',');
            string inputText = Console.ReadLine();

            foreach (var item in bannedWords)
            {
                if (inputText.Contains(item))
                {
                    inputText = inputText.Replace(item, new string('*', item.Length));
                }
            }
            Console.WriteLine(inputText);
            
        }
    }
}
