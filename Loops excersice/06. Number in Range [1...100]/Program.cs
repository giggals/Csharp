using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            while (n >= 1 && n <= 100)
            {
                Console.WriteLine(n);
                continue;
               
            }
            while (n < 1 || n > 100)
            {
                Console.WriteLine("Invalid number!");
                int number = int.Parse(Console.ReadLine());
            }
            
        }
    }

