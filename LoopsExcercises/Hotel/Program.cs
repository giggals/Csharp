using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string Month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double  studioPrice = 0;
            double doublePrice = 0;
            double  suitePrice = 0;
            


            switch (Month)
            {
                case "May":
                case "October":
                   
                    studioPrice = 50;
                    doublePrice = 65;
                    suitePrice = 75 ;

                    if (nights > 7)
                    {
                        studioPrice *= 0.95;
                        
                    }
                    break;

                case "June":
                case "September":
                   
                    studioPrice = 60 ;
                    doublePrice = 72 ;
                    suitePrice = 82 ;
                    if (nights > 14)
                    {
                        doublePrice = doublePrice * 0.90;
                    }
                    break;
                case "July":
                case "August":
                case "December":
                   
                    studioPrice = 68;
                    doublePrice = 77;
                    suitePrice = 89;
                    if (nights > 14)
                    {
                        suitePrice *= 0.85;
                        
                    }

                    break;
               
            }
            var totalStudioPrice = studioPrice * nights;
            var totaldoublePrice = doublePrice * nights;
            var totalSuietPrice = suitePrice * nights;

            if ((Month == "September" || Month == "October") && nights > 7)
            {
                totalStudioPrice -= studioPrice ;
            }



            Console.WriteLine($"Studio: {totalStudioPrice:F2} lv.");
            Console.WriteLine($"Double: {totaldoublePrice :F2} lv.");
            Console.WriteLine($"Suite: {totalSuietPrice:F2} lv.");

           

            
        }
    }
}
