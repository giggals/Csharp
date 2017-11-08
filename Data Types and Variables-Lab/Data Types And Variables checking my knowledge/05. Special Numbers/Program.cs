using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            bool isTrue = true;

            for (int i = 1; i <= n; i++)
            {
                int sumDigits = 0;
                int digits = i;

                while (digits > 0)
                {
                    sumDigits = sumDigits + digits % 10;
                    digits = digits / 10;
                }
               
                if (sumDigits == 5 || sumDigits == 7 || sumDigits == 11)
                {
                   isTrue = true;
                }
                else
                {
                    isTrue = false;    
                }
                Console.WriteLine($"{i} -> {isTrue}");
            }
        }
    }
}
