using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Decimal_To_Binary_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int zero = 0;
            int one = 1;

            Stack<string> result = new Stack<string>();


            if (number == 0)
            {
                Console.WriteLine(0);
            }

            while (number > 0)
            {
                if (number % 2 == 0)
                {
                    number /= 2;

                    result.Push(zero.ToString());
                    result.Reverse();
                }
                else if (number % 2 == 1)
                {
                    number /= 2;
                    result.Push(one.ToString());

                }
                
            }
            Console.WriteLine(string.Join("",result));
        }
    }
}
