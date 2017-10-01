using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactor_Volume_of_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenght = 0;

            Console.Write("Length: ");
            lenght = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            double width = 0;
            width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double height = 0;
            height  = double.Parse(Console.ReadLine());
            height  = (lenght * width * height ) / 3 ;
            Console.WriteLine($"Pyramid Volume: {height:F2}");
           
        }
    }
}
