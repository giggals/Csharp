using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Check_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n < 0 || n % 2 == 0 || n % 2 == 1)
            {
                Console.WriteLine("Not Prime");
            }
            else
            {
                Console.WriteLine("Prime");
            }
            

        }
    }
}
