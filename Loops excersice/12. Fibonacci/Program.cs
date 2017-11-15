using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n < 2)
            {
                Console.WriteLine(1);
            }
            int first = 1;
            int second = 1;

            
           
            for (int i = 2; i <= n ; i++)
            {
              int  result = first + second;
                first = second;
               second = result;
               
            }
            Console.WriteLine(second);
        }
    }
}
