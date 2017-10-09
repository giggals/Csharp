using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;


namespace Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] nums = Console.ReadLine()
                 .Split(' ')
                 .Select(double.Parse)
                 .ToArray();

            foreach (var x in nums)
            {
                double rounded = Math.Round(x, 0, MidpointRounding.AwayFromZero);
                Console.WriteLine(x + " => " + rounded);
            }
        } 
    }
}
