using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
           int reminder = n;

            while (reminder != 0)
            {
                int lastDigit = reminder % 10;
                reminder = reminder / 10;

                sum += lastDigit;

            }

            Console.WriteLine(sum);
        }
    }
}
