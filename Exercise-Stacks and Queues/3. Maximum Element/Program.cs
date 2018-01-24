using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Maximum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>();
            Stack<int> maxNumbers = new Stack<int>();

            int biggestNumber = int.MinValue;

           
                for (int i = 0; i < n; i++)
                {
                    string[] array = Console.ReadLine().Split(' '.ToString().ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                    int command = int.Parse(array[0]);
                    
                    if (command == 1)
                    {
                        int number = int.Parse(array[1]);
                        stack.Push(number);
                        if (biggestNumber < number)
                        {
                            biggestNumber = number;
                            maxNumbers.Push(biggestNumber);
                        }
                        
                    }
                    else if (command == 2)
                    {
                        if (stack.Pop() == biggestNumber)
                        {
                            maxNumbers.Pop();
                            if (maxNumbers.Count() != 0)
                            {
                                biggestNumber = maxNumbers.Peek();
                            }
                            else
                            {
                                biggestNumber = int.MinValue;
                            }
                        }
                        
                    }
                    else if (command == 3)
                    {
                        Console.WriteLine(biggestNumber);
                    }
                    
                }
            
        }
    }
}
