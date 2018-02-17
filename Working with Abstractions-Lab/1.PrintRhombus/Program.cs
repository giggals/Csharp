using System;

namespace PrintRhombus
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            for (int counter = 1; counter <= rows; counter++)
            {
                PrintRhombus(rows, counter);
            }
           
            for (int i = rows - 1; i > 0; i--)
            {
                PrintRhombus(rows, i);
            }
            
        }

        private static void PrintRhombus(int rows,int counter)
        {
            for (int i = 0; i < rows - counter; i++)
            {
                Console.Write(" ");
            }
            for (int i = 0; i < counter; i++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
}
