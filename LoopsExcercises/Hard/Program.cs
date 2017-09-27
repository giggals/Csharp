using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hard
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (input.EndsWith("y"))
            {
                input = input.Remove(input.Length - 1);
                input += "ies";

            }
            else if (input.EndsWith("o") || input.EndsWith("ch") ||
              input.EndsWith("s") || input.EndsWith("sh") || input.EndsWith("x") || input.EndsWith("z"))
            {
                input += "es";
            }
            else input += "s";
            Console.WriteLine(input);

        }
    }
}
