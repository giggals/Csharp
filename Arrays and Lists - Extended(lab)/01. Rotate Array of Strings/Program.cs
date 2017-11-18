using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_and_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split();
            string[] rotatedArray = new string[array.Length];
            
            for (int i = 0; i < array.Length - 1; i++)
            {
                rotatedArray[i + 1] = array[i];

                string lastElement = array[rotatedArray.Length - 1];
                rotatedArray[0] = lastElement;
                
            }

            Console.WriteLine(string.Join(" ", rotatedArray));
        }
    }
}
