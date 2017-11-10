using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
           

           

            for (int i = 1; i <= n; i++)
            {
                int sum = 0;
                var num  = i;
               
                    sum = sum / 10;

                while (num > 0)
                {
                    int digits = num % 10;
                    sum = sum + digits;
                    num = num / 10;
                }
                 
                   bool isTrue = (sum == 5 || sum == 7 || sum == 11);
                
                Console.WriteLine($"{i} -> {isTrue}");
            }
        }
    }
}
