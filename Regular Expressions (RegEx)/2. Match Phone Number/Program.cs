using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _2.Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string firstPattern = @"\+\d{3}[\s+]\d+[\s+|-]\d{3}[\s+]\d{4}";

            Match match = Regex.Match(input, firstPattern);
            
            string secondPattern = @"\+\d{3}[-]\d+[-]\d{3}[-]\d{4}";

            Match secondmatch = Regex.Match(input, secondPattern);

            Console.Write(match + ", " + secondmatch);
            Console.WriteLine();

           

        }
    }
}
