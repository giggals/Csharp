using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            var first = input[0];
            var second = input[1];
            var result = GetCharacters(first, second);

            Console.WriteLine(result);
            
        }

        public static long GetCharacters ( string first, string second)
        {
            var minStringLenght = Math.Min(first.Length, second.Length);
            var sum = 0;

            for (int i = 0; i < minStringLenght; i++)
            {
                sum += first[i] * second[i];
            }

            if (first.Length - minStringLenght > 0)
            {
                for (int i  = minStringLenght; i < first.Length; i ++)
                {
                    sum = sum + first[i];
                }
            }
            else
            {
                for (int i = minStringLenght; i < second.Length; i++)
                {
                    sum += second[i];
                }
            }
            return sum;

        }


    } 

    
}
