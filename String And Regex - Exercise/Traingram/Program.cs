using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace String_And_Regex___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"^(\<\[[^A-Za-z0-9\n]*]\.)(\.\[[A-Za-z0-9]*]\.)*$";
            
            while (input != "Traincode!")
            {

                Regex.IsMatch(input, pattern);

                if (Regex.IsMatch(input, pattern))
                {
                    Console.WriteLine(input);
                }

                input = Console.ReadLine();
            }

        }
    }
}
