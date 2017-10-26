using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;


namespace _01.Convert_from_base_10_to_base_N
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            int baseNumber = int.Parse(input[0]);
            BigInteger baseTenNumber = BigInteger.Parse(input[1]);

            StringBuilder result = new StringBuilder();

            while (baseTenNumber > 0)
            {
                BigInteger reminder = baseTenNumber % baseNumber;
                result.Insert(0, reminder.ToString());
                baseTenNumber /= baseNumber;
            }

            Console.WriteLine(result);

        }
    }
}
