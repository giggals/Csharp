using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Resurrection
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {
                long totalLenth = long.Parse(Console.ReadLine());
                decimal totalWidth = decimal.Parse(Console.ReadLine());
                long lenthOFWing = long.Parse(Console.ReadLine());

                decimal result = (totalLenth * totalLenth) * ((totalWidth) + 2 * (lenthOFWing));
                Console.WriteLine(result);
            }
        }
    }
}
