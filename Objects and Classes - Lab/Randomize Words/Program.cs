using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();

            Random rnd = new Random();

            for (int i = 0; i < input.Length; i++)
            {
                int randomizer = rnd.Next(input.Length);
            }

            Console.WriteLine(string.Join("\r\n",input));
        }
    }
}
