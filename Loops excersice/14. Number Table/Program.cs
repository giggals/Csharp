using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Number_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int rows = 1; rows <= n ; rows++)
            {
                for (int i = rows; i <=n ; i++)
                {
                    Console.Write(i + " ");
                   
                }
                for (int i = n - 1; i > n - rows; i--)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
            
        }
    }
}
