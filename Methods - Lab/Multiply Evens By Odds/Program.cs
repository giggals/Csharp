using System;
using System.Linq;
using System.Collections;

namespace MultiplyEvensbyOdds
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int programentry = Math.Abs(int.Parse(Console.ReadLine()));
            int finalresulteven = GetMultipleOfEvensorOdds(programentry);
            Console.WriteLine(finalresulteven);
        }

        public static int GetMultipleOfEvensorOdds(int a)
        {
            int lastdigit = 0;
            int finalscoreevens = 0;
            int finalscoreodds = 0;
            while (a > 0)
            {
                lastdigit = a % 10;
                a = a / 10;
                if (lastdigit % 2 == 0)
                {
                    finalscoreevens += lastdigit;
                }
                else
                {
                    finalscoreodds += lastdigit;
                }
            }
            return finalscoreevens * finalscoreodds;
        }
    }
}