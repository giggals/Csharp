using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersToRead = int.Parse(Console.ReadLine());

            int oddNumbers = 0;
            int evenNumbers = 0;


            for (int i = 0; i < numbersToRead; i++)
            {
                int inputNumbers = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenNumbers = evenNumbers + inputNumbers;
                }
                else
                {
                    oddNumbers = oddNumbers + inputNumbers;
                }
               
            }
            if (evenNumbers == oddNumbers)
            {
                Console.WriteLine($"Yes, Sum = {evenNumbers}");
            }
            else
            {
                Console.WriteLine($"No, Diff = {Math.Abs(evenNumbers - oddNumbers)}");
            }
            Console.WriteLine();
        }
    }
}
