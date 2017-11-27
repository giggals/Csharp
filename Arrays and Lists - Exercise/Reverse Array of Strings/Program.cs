using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split();

            for (int i = array.Length; i > 0; i--)
            {
                Console.WriteLine(string.Join(" ",array[i - 1]));
            }

           
        }
    }
}
