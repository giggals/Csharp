using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparing_floats
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            bool equalOrNot;
            double difference = Math.Abs(num1 - num2);

            if (difference > 0.000001 )
            {
                equalOrNot = false;
                Console.WriteLine(equalOrNot);
            }
            else
            {
                equalOrNot = true;
                Console.WriteLine(equalOrNot);
            }

        }
    }
}
