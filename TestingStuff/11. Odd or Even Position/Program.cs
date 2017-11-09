using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Odd_or_Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double evenSum = 0;
             double evenMin = int.MaxValue;
            double evenMax = int.MinValue;
            double oddSum = 0;
            double oddMin = int.MaxValue;
            double oddMax = int.MinValue;

            for (int i = 1; i <= n; i++)
            {
                double numbers = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                   
                    if (numbers < evenMin)
                    {
                        evenMin = numbers;
                    }
                     if (numbers > evenMax)
                     {
                        evenMax = numbers;
                     }
                    evenSum += numbers;

                    if (n == 1)
                    {
                        Console.WriteLine($"OddSum=0");
                        Console.WriteLine($"OddMin=No");
                        Console.WriteLine($"OddMAx=No");
                        Console.WriteLine($"EvenSum={numbers}");
                        Console.WriteLine($"EvenMin={numbers}");
                        Console.WriteLine($"EvenMax={numbers}");
                        return;
                    }
                }

                if (i % 2 == 1)
                
                {
                  
                    if (numbers < oddMin)
                    {
                        oddMin = numbers;
                    }

                    if (numbers > oddMax)
                    {
                        oddMax = numbers;
                    }
                    oddSum += numbers;

                    if (n == 1)
                    {
                        Console.WriteLine($"OddSum={numbers}");
                        Console.WriteLine($"OddMin={numbers}");
                        Console.WriteLine($"OddMAx={numbers}");
                        Console.WriteLine($"EvenSum=0");
                        Console.WriteLine($"EvenMin=No");
                        Console.WriteLine($"EvenMax=No");
                        return;
                    }
                    
                }
                
            }
            if (n == 0)
            {
                Console.WriteLine($"OddSum=0");
                Console.WriteLine($"OddMin=No");
                Console.WriteLine($"OddMAx=No");
                Console.WriteLine($"EvenSum=0");
                Console.WriteLine($"EvenMin=No");
                Console.WriteLine($"EvenMax=No");

                return ;
            }
            
            Console.WriteLine($"OddSum={oddSum}");
            Console.WriteLine($"OddMin={oddMin}");
            Console.WriteLine($"OddMAx={oddMax}");
            Console.WriteLine($"EvenSum={evenSum}");
            Console.WriteLine($"EvenMin={evenMin}");
            Console.WriteLine($"EvenMax={evenMax}");
        }
    }
}
