using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            int max = int.MinValue;
            
            for (int i = 0; i < n; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                
                if (numbers > max)
                {
                    max = numbers; 
                }
                sum += numbers;
            }

            int sumOFoherNumbers = sum - max;

            if (sumOFoherNumbers == max)
            {
                Console.WriteLine($"Yes Sum {sumOFoherNumbers}");
            }
            else
            {
                Console.WriteLine($"No Diff {Math.Abs(max - sumOFoherNumbers)}");
            }
            
        }
    }
}
