using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            string hallName = "";
            


            while (package == "Normal" && people <= 50)
            {
                 hallName = "Small Hall";
                decimal hallsPrice = 2500m;
                decimal packagePrice = 500m;
                decimal totalPrice = hallsPrice + packagePrice;
                decimal discountPrice = totalPrice - (totalPrice * 0.05m);
                decimal pricePerPerson = discountPrice / people;

                Console.WriteLine($"We can offer you the {hallName }");
                Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
                break;
            }
            while (package == "Normal" && (people >= 51 && people <= 100))
            {
                hallName = "Terrace";
                decimal hallsPrice = 5000m;
                decimal packagePrice = 500m;
                decimal totalPrice = hallsPrice + packagePrice;
                decimal discountPrice = totalPrice - (totalPrice * 0.05m);
                decimal pricePerPerson = discountPrice / people;

                Console.WriteLine($"We can offer you the {hallName }");
                Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
                break;
            }
            while (package == "Normal" && (people >= 101 && people <= 120))
            {
                hallName = "Great Hall";
                decimal hallsPrice = 7500m;
                decimal packagePrice = 500m;
                decimal totalPrice = hallsPrice + packagePrice;
                decimal discountPrice = totalPrice - (totalPrice * 0.05m);
                decimal pricePerPerson = discountPrice / people;

                Console.WriteLine($"We can offer you the {hallName}");
                Console.WriteLine($"The price per person is {pricePerPerson:F2}$");  
                break;
            }

            while (package == "Gold" && people <= 50)
            {
                hallName = "Small Hall";
                decimal hallsPrice = 2500m;
                decimal packagePrice = 750m;
                decimal totalPrice = hallsPrice + packagePrice;
                decimal discountPrice = totalPrice - (totalPrice * 0.1m);
                decimal pricePerPerson = discountPrice / people;

                Console.WriteLine($"We can offer you the {hallName}");
                Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
                break;
            }
            while (package == "Gold" && (people >= 51 && people <= 100))
            {
                hallName = "Terrace";
                decimal hallsPrice = 5000m;
                decimal packagePrice = 750m;
                decimal totalPrice = hallsPrice + packagePrice;
                decimal discountPrice = totalPrice - (totalPrice * 0.1m);
                decimal pricePerPerson = discountPrice / people;

                Console.WriteLine($"We can offer you the {hallName}");
                Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
                break;
            }
            while (package == "Gold" && (people >= 101 && people <= 120))
            {
                hallName = "Great Hall";
                decimal hallsPrice = 7500m;
                decimal packagePrice = 750m;
                decimal totalPrice = hallsPrice + packagePrice;
                decimal discountPrice = totalPrice - (totalPrice * 0.1m);
                decimal pricePerPerson = discountPrice / people;

                Console.WriteLine($"We can offer you the {hallName}");
                Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
                break;
            }
            while (package == "Platinum" && people <= 50)
            {
                hallName = "Small Hall";
                decimal hallsPrice = 2500m;
                decimal packagePrice = 1000m;
                decimal totalPrice = hallsPrice + packagePrice;
                decimal discountPrice = totalPrice - (totalPrice * 0.15m);
                decimal pricePerPerson = discountPrice / people;

                Console.WriteLine($"We can offer you the {hallName}");
                Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
                break;
            }
            while (package == "Platinum" && (people >= 51 && people <= 100))
            {
                hallName = "Terrace";
                decimal hallsPrice = 5000m;
                decimal packagePrice = 1000m;
                decimal totalPrice = hallsPrice + packagePrice;
                decimal discountPrice = totalPrice - (totalPrice * 0.15m);
                decimal pricePerPerson = discountPrice / people;

                Console.WriteLine($"We can offer you the {hallName}");
                Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
                break;
            }
            while (package == "Platinum" && (people >= 101 && people <= 120))
            {
                hallName = "Great Hall";
                decimal hallsPrice = 7500m;
                decimal packagePrice = 1000m;
                decimal totalPrice = hallsPrice + packagePrice;
                decimal discountPrice = totalPrice - (totalPrice * 0.15m);
                decimal pricePerPerson = discountPrice / people;

                Console.WriteLine($"We can offer you the {hallName}");
                Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
                break;
            }
            while ((package == "Gold" || package == "Normal" || package == "Platinum") && people >= 121)
            {
                Console.WriteLine("We do not have an appropriate hall.");
                break;
            }






        }
    }
}
