using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Hornet_Wings
{
    class Program
    {
        static void Main(string[] args)
        {
            int wingFlaps = int.Parse(Console.ReadLine());
            decimal distance = decimal.Parse(Console.ReadLine());
            int edurence = int.Parse(Console.ReadLine());

            decimal distanceResult = 1m;
            long seconds = 0;

            distanceResult = (wingFlaps / 1000) * distance;
            long hornetFlaps = wingFlaps / 100;
            seconds = (wingFlaps / edurence) * 5 + hornetFlaps;

            Console.WriteLine($"{distanceResult:f2} m.");
            Console.WriteLine($"{seconds} s.");


        }
    }
}
