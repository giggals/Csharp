using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bon_Appetit
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputLine = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int Ordereditems = inputLine[0];
            int notOrderedIndex = inputLine[1];
            

            int[] secondInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int notorderedItem = secondInput[notOrderedIndex];

            int chargedSum = int.Parse(Console.ReadLine());

            int sum = 0;
            
            for (int i = 0; i < secondInput.Length ; i++)
            {
                sum += secondInput[i];
            }
            sum = (sum - notorderedItem) / 2;

            int result = chargedSum - sum;

            if (sum == chargedSum)
            {
                Console.WriteLine("Bon Appetit");
            }
            else
            {
                Console.WriteLine(result);
            }
            
        }
    }
}
