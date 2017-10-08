using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FactorialTrailingZeroes
{
    class FactorialTrailingZeroes
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            GetTrailingZeroes(factorial);
        }
        static void GetTrailingZeroes(decimal num)
        {

            decimal timesZero = 0;
            while (num % 10 == 0)
            {
                num = num / 10;
                timesZero++;
            }
            Console.WriteLine(timesZero);
        }
    }
}