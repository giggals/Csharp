using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme6
{
    class Program
    {
        static void Main(string[] args)
        {
            int orders = int.Parse(Console.ReadLine());

          
            decimal price = 0;
            decimal totalPrice = 0;

            for (int i = 0; i < orders; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                DateTime date = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                int daysInMonth = DateTime.DaysInMonth(date.Year, date.Month);
                long capsuleCount = long.Parse(Console.ReadLine());

                    price = (daysInMonth * capsuleCount) * pricePerCapsule;
                    totalPrice += price;
                    Console.WriteLine($"The price for the coffee is: ${price:f2}");
            }
            
            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}
