using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods___Lab
{
    class Program
    {
        private static void PrintHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("--------------------------------");

        }
        private static void PrintBody()
        {
            Console.WriteLine("Charged to____________");
            Console.WriteLine("Received by______________");


        }
        private static void PrintFooter()
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine($"\u00A9 SoftUni");
        }
        static void Main(string[] args)
        {
            PrintHeader();
            PrintBody();
            PrintFooter();
        }
       
    }
}
