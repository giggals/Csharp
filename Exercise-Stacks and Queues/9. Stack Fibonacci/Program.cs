using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Recursive_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Stack<long> fibNumbers = new Stack<long>();

            long result = 0;

            fibNumbers.Push(0);
            fibNumbers.Push(1);

            for (int i = 0; i < n - 1; i++)
            {
                long firstNumber = fibNumbers.Pop();
                long seconNumber = fibNumbers.Pop();

                fibNumbers.Push(firstNumber);
                result = firstNumber + seconNumber;
                fibNumbers.Push(result);
            }
            Console.WriteLine(result);


        }
    }
}
