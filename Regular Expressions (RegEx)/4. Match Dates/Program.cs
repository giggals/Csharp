using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _4.Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            string dates = Console.ReadLine();
            string firstPattern = @"([0-9]{2})\/([A-Z]{1}[a-z]+)\/([0-9]{4})";

            MatchCollection firstmatches = Regex.Matches(dates, firstPattern);

            foreach (Match date in firstmatches)
            {
                var days = date.Groups[1].Value;
                var month = date.Groups[2].Value;
                var year = date.Groups[3].Value;

                Console.WriteLine($"Day: {days}, Month: {month}, Year: {year}");
            }

            string secondPattern = @"([0-9]{2})\-([A-Z]{1}[a-z]+)\-([0-9]{4})";

            MatchCollection secondmatches = Regex.Matches(dates, secondPattern);

            foreach (Match date in secondmatches)
            {
                var days = date.Groups[1].Value;
                var month = date.Groups[2].Value;
                var year = date.Groups[3].Value;

                Console.WriteLine($"Day: {days}, Month: {month}, Year: {year}");
            }
            string thirdPattern = @"([0-9]{2})\.([A-Z]{1}[a-z]+)\.([0-9]{4})";

            MatchCollection thirdmatches = Regex.Matches(dates, thirdPattern);

            foreach (Match date in thirdmatches)
            {
                var day = date.Groups[1].Value;
                var month = date.Groups[2].Value;
                var year = date.Groups[3].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }

        }
        
    }
}
