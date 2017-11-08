using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Exact_Sum_of_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());

            decimal totalSum = 0;

            for (int i = 0; i < numbersCount; i++)
            {
                decimal inputNumbers = decimal.Parse(Console.ReadLine());
                
                totalSum = totalSum + inputNumbers;
            }

            Console.WriteLine(totalSum);
            
        }
    }
}
