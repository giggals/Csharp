using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_Frame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int calculated = n - 2;
            var topAndBottomRows = "+";
            for (int i = 0; i < calculated; i++)
            {
                topAndBottomRows = topAndBottomRows + " -";
            }
            Console.WriteLine($"{topAndBottomRows} +");

            var middleRows = "|";
            for (int j = 0; j < calculated; j++)
            {
                middleRows = middleRows + " -";
            }
            middleRows = middleRows + " |";

            for (int i = 0; i < calculated; i++)
            {
                Console.WriteLine(middleRows);
            }
           

            Console.WriteLine($"{topAndBottomRows} +");
        }
    }
}
