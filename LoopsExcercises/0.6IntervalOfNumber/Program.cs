using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._6IntervalOfNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            for (int i = 0;i > num1 && i < num2 ; i ++)
            {
                Console.WriteLine(i);
                
            }

        }
    }
}
