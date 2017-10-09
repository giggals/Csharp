using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condense_Array_to_Number
{
    class Condense_Array_to_Number
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            while (input.Length > 1)
            {
                int[] condensedArray = new int[input.Length - 1];
                for (int i = 0; i < input.Length - 1; i++)
                    condensedArray[i] = input[i] + input[i + 1];
                input = condensedArray;
            }
            Console.WriteLine(input[0]);
        }
    }
}