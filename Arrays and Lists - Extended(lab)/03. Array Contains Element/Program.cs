using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Array_Contains_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int containedNumbers = int.Parse(Console.ReadLine());

            string text = "";

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers.Contains(containedNumbers))
                {
                    text = "yes";
                }
                else
                {
                    text = "no";
                }
                
            }
            Console.WriteLine(text);
        }
    }
}
