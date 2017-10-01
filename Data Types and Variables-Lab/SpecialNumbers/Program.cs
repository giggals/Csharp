using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int sumOfDigits = 0;
                int digits = i;
                while (digits > 0)
                {
                    sumOfDigits = sumOfDigits + digits % 10;
                    digits = digits / 10;
                }
                bool specialNumber = (sumOfDigits == 5 || sumOfDigits == 7 || sumOfDigits == 11);
                Console.WriteLine($"{i} -> {specialNumber }");
            }
        }
    }
}
