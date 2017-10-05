using System;

namespace _03.Printing_Triangle
{
    public class Program
    {
        public static void Main(string[] args)
        {

            PrintTriagle(int.Parse(Console.ReadLine()));

        }
        public static void PrintColumns(int row)
        {
            for (int col = 1; col <= row; col++)
            {
                Console.Write($"{col} ");
            }
            Console.WriteLine();

        }
        public static void PrintTriagle(int n)
        {
            for (int row = 1; row <= n; row++)
            {
                PrintColumns(row);
            }
            for (int row = n - 1; row >= 1; row--)
            {
                PrintColumns(row);
            }
        }

    }
}