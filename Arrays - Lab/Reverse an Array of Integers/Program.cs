using System;

namespace Reverse_an_Array_of_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] items = input.Split(' ');

            for (int i = items.Length; i >= 0; i--)
            {
                Console.Write(items[i]);
                Console.Write(" ");
            }
        }
    }
}
