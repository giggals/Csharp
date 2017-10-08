using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_CHekerrr
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            if (number == 0 || number == 1)
            {
                Console.WriteLine("False");
                return;
            }
            Console.WriteLine(IsPrime(number));
        }
        
        static bool IsPrime(long number )
        {

            bool IsPrime = true;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    IsPrime = false;
                }
            }
            return IsPrime;
            
        }
        
    }
}
