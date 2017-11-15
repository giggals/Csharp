using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Enter_Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n = int.Parse(Console.ReadLine());
                if ( n  % 2 == 0)
                {
                    Console.WriteLine($"Even number entered: {n}");
                }

                while (!(n % 2 == 0))
                {
                    Console.WriteLine("Invalid Number");
                    n = int.Parse(Console.ReadLine());
                   
                    if (n % 2 == 0)
                    {
                        Console.WriteLine($"Even number entered: {n}");
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Number!");
            }
        }
    }
}
