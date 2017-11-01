using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExamPreperation
{
    class Program
    {
        

        static void Main(string[] args)
        {
            int numberOfOrders = int.Parse(Console.ReadLine());
            decimal[] priceAndnumber = new decimal[1];
            decimal numberOfCapsule = priceAndnumber[0];
            decimal pricePerCapsule = priceAndnumber[1];

            for (int i = 0; i < numberOfOrders; i++)
            {
                
                string dateAsText = Console.ReadLine();
                DateTime date = DateTime.ParseExact(dateAsText, "d/M/yyyy", CultureInfo.InvariantCulture);
                int daysInMonth = DateTime.DaysInMonth(date.Year, date.Month);
               
                decimal price = (daysInMonth * numberOfCapsule) * pricePerCapsule;
                decimal totalPrice;

                if (numberOfOrders == 1)
                {
                    price = (daysInMonth * numberOfCapsule) * pricePerCapsule;
                    totalPrice = price;
                    Console.WriteLine($"The price for the coffee is: ${price:f2}");

                    Console.WriteLine($"Total: ${totalPrice:f2}");
                }

                if (numberOfOrders >= 2)
                {
                    
                }

            }

        }

    }

}

