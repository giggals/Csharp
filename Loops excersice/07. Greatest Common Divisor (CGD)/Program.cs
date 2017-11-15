using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Greatest_Common_Divisor__CGD_
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int oldb;
            while (b != 0)
            {
                oldb = b;
                b = a % b;
                a = oldb;
            }
            Console.WriteLine(a);


            //int firstNumber = int.Parse(Console.ReadLine());
            //int secondNumber = int.Parse(Console.ReadLine());

            //int devider = 0;

            //for (int i = 1; i <=Math.Min(firstNumber, secondNumber) ; i++)
            //{
            //    if (firstNumber % i == 0 && secondNumber % i == 0 )
            //    {
            //        devider = i;
            //    }
            //}
            //Console.WriteLine(devider);
        }
    }
}
