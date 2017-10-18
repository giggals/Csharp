using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects_and_Classes___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            DateTime myDate = DateTime.ParseExact(input, "d-M-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(myDate.DayOfWeek);

        }
    }
}
