using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_and_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            string variable1 = "Hello";
            string variable2 = "World";

            object variable3 = variable1 + ' ' + variable2;

            Console.WriteLine(variable3 );
        }
    }
}
