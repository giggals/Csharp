using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            
            var result = 0;
            Stack<string> stack = new Stack<string>(input.Reverse());

            while (stack.Count > 1)
            {
                var firstNumber = int.Parse(stack.Pop());
                var operators = stack.Pop();
                var secondNumber = int.Parse(stack.Pop());

                if (operators == "+")
                {
                    stack.Push((firstNumber + secondNumber).ToString());
                }
                else
                {
                    stack.Push((Math.Abs(firstNumber - secondNumber).ToString()));
                }
            }

            Console.WriteLine(stack.Pop());

           
        }
    }
}
