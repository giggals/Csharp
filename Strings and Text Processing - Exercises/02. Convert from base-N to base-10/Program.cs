using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _02.Convert_from_base_N_to_base_10
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Trim().Split(' ');
            int baseNum = int.Parse(input[0]);
            char[] baseTenNum = input[1].ToCharArray();

            BigInteger result = new BigInteger(0);

            for (int i = 0; i < baseTenNum.Length; i++)
            {
                int currNum = (int)Char.GetNumericValue(baseTenNum[i]);
                result += currNum * BigInteger.Pow(baseNum, baseTenNum.Length - i - 1);
            }

            Console.WriteLine(result);

        }
    }
}
