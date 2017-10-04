using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable_in_Hexadecimal_Format
{
    class Program
    {
        static void Main(string[] args)
        {
            string  numberinHex =(Console.ReadLine());
            int number = Convert.ToInt32(numberinHex,16);
            
            Console.WriteLine($"{number}");
        }
    }
}
