using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks_and_Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToCharArray();
            
            Stack<string> reverseStack = new Stack<string>();

            foreach (var item in input)
            {
                reverseStack.Push(item.ToString());
            }
            
            Console.WriteLine(string.Join("",reverseStack));
        }
    }
}
