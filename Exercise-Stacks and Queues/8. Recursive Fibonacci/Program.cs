using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//88 in judge!
namespace _8.Recursive_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            GetFibonaci(input);

        }

        static long GetFibonaci(long input)
        {
            Stack<long> stack = new Stack<long>();

            stack.Push(1);
            stack.Push(1);

            long result = 0;

            for (int i = 0; i < input - 2; i++)
            {
                long firrstNumber = stack.Pop();
                long secondNumber = stack.Pop();

                stack.Push(firrstNumber);
                result = firrstNumber + secondNumber;
                stack.Push(result);
            }

            Console.WriteLine(result);
            return result;
        }
    }
}
