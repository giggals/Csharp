using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            int number = 1;
            int row = 1;


            while (number <= n)
            {


                for (int i = 0; i < row; i++)
                {
                    Console.Write(number + " ");
                    number++;

                    if (number > n)
                    {
                        break;
                    }
                }

                row++;
                Console.WriteLine();
            }
        }
    }
}
