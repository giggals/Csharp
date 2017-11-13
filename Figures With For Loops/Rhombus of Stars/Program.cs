using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rhombus_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int spaces = n - 1;

           
            for (int i = 1; i <= n ; i++)
            {
                for (int s = 0; s <= spaces; s++)
                {
                    Console.Write(" ");
                }
                
                for (int j = 0; j < i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.Write(" | ");

                for (int j = 0; j < i - 1; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
                spaces--;
            }
            
        }
    }
}
