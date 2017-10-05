using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
           double fahrenheit = double.Parse(Console.ReadLine());
            double celsius = FahrenhainToCelsius(fahrenheit);
            Console.WriteLine($"{celsius:F2}");
        }
       
        static double FahrenhainToCelsius(double n)
        {
            return (n - 32) * 5 / 9;
        }
    }
}
