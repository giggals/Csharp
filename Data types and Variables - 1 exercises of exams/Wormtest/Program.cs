using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wormtest
{
    class Program
    {
        static void Main(string[] args)
        {
            int wormsLenth = int.Parse(Console.ReadLine());
            double wormswidth = double.Parse(Console.ReadLine());

            long convertedLenth = wormsLenth * 100;
            double remainderPercantage = (convertedLenth % wormswidth);

            if (remainderPercantage == 0 ||  wormswidth == 0)
            {
                Console.WriteLine($"{(convertedLenth * wormswidth):f2}");
            }
            else
            {
                Console.WriteLine($"{((convertedLenth  / wormswidth) * 100):f2}%");
            }
            
        }
    }
}
