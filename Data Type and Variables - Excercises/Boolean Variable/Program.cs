using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            string variable = Console.ReadLine();

            bool convertedVariable = Convert.ToBoolean(variable);

            while (convertedVariable == true)
            {
                Console.WriteLine("Yes");
                break;
            }
            while (convertedVariable == false )
            {
                Console.WriteLine("No");
                break;
            }
        }
    }
}
