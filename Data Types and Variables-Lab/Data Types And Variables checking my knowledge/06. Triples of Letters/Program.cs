using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Triples_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOFletters = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOFletters; i++)
            {
                for (int j = 0; j < numberOFletters ; j++)
                {
                    for (int k = 0; k < numberOFletters ; k++)
                    {
                        char letter = (char)('a' + i);
                        char letter2 = (char)('a' + j);
                        char letter3 = (char)('a' + k);
                        Console.WriteLine($"{letter}{letter2}{letter3}");
                    }
                  
                }
            }
        }
    }
}
