using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max__Method
{
    class Program
    {
        static void GetMax(int a, int b, int c)
        {
            if (a > b)
            {
                Console.WriteLine(a);
            }
            if (b > a)
            {
                if (c > a && c > b)
                {
                    Console.WriteLine(c);
                    return;
                }
                Console.WriteLine(b);

            }
            
        }

        static void Main(string[] args)
        {
            GetMax(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));

        }


    }
}
