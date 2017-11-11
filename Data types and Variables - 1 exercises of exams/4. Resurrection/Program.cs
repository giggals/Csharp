using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Resurrection
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPhoenix = int.Parse(Console.ReadLine());

            decimal totalyears = 1;

            for (int i = 0; i < numberOfPhoenix; i++)
            {
                ulong totalLenth = ulong.Parse(Console.ReadLine());
                decimal totalwidth = decimal.Parse(Console.ReadLine());
                ulong lenthOfWing = ulong.Parse(Console.ReadLine());

                totalyears = (totalLenth * totalLenth) * (totalwidth + 2 * (lenthOfWing));

                Console.WriteLine(totalyears);

            }


        }
    }
}
