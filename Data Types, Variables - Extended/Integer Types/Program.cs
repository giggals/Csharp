using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Types__Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            uint n2 = uint.Parse(Console.ReadLine());
            long n3 = long.Parse(Console.ReadLine());
            long n4 = long.Parse(Console.ReadLine());
            
            Console.Write($"{n} {n2} {n3} {n4}");
            Console.WriteLine();
        }
    }
}
