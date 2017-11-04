using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_23._10._2016
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            long runners = long.Parse(Console.ReadLine());
            int numberOfLaps = int.Parse(Console.ReadLine());
            int laplenth = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            decimal moneyPerKilometer = decimal.Parse(Console.ReadLine());

            decimal moneyRaised = 0;

            if (runners > capacity * days)
            {
                runners = capacity * days;
            }

            decimal km = (runners * numberOfLaps * laplenth ) / 1000;
            moneyRaised = km * moneyPerKilometer;

            Console.WriteLine($"Money raised: {moneyRaised:f2}");
        }
    }
}
