using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int picuresCount = int.Parse(Console.ReadLine());
            int filterTime = int.Parse(Console.ReadLine());
            int percentage = int.Parse(Console.ReadLine());
            int uploadTime = int.Parse(Console.ReadLine());

            decimal goodPhotos = picuresCount * percentage / 100;

            decimal firstseconds = goodPhotos * filterTime;

            decimal secondseconds = goodPhotos * uploadTime;

            decimal totalTimeSeconds = firstseconds + secondseconds;
            decimal minuts = totalTimeSeconds / 60;
            decimal hours = minuts * 60;
            decimal days = hours * 24;
            var result = "days:hours:minuts:totalTimeSeconds";
            DateTime date = DateTime.ParseExact(result, "d:HH:mm:ss", CultureInfo.InvariantCulture);

            Console.WriteLine(date);

        }
    }
}
