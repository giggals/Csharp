using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _1.Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string names = Console.ReadLine();
            string pattern = @"\b[A-Z]{1}[a-z]+\s+[A-Z][a-z]+\b";

           
            MatchCollection word = Regex.Matches(names , pattern);

            foreach (Match item in word)
            {
                Console.Write(item.Value + " ");
               
            }

            Console.WriteLine();
            
        }
    }
}
