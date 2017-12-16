using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam___10_December_2017___Part_I
{
    class Program
    {
        static void Main(string[] args)
        {
            int regionsCount = int.Parse(Console.ReadLine());
            decimal density = decimal.Parse(Console.ReadLine());


            decimal regionCoeficent = 0;

            for (int i = 0; i < regionsCount; i++)
            {
                string[] input = Console.ReadLine().Split();
                long raindropsCount = long.Parse(input[0]);
                int squareMeters = int.Parse(input[1]);

                regionCoeficent += raindropsCount / (decimal)squareMeters;
                
            }
            if (density != 0)
            {
                Console.WriteLine($"{(regionCoeficent / density):f3}");
            }
            else
            {
                Console.WriteLine($"{regionCoeficent:f3}");
            }
        }
    }
}
