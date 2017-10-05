using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sign_Of_Integer_Number
{
    class Program
    {
        static void Main ()
        {
            
            PrintSign(int.Parse(Console.ReadLine()));
        }

        static void PrintSign(int number)
        {
            if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            if (number == 0)
            {
                Console.WriteLine($"The number {number} is zero.");
            }
        }
    }


}   

