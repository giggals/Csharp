using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _1.Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"([\w.-]+\@)([a-zA-z-]+\.)+([a-z]+)+";



            Regex reg = new Regex(pattern);
            MatchCollection matchCollection = reg.Matches(input);


            foreach (Match email in matchCollection)
            {
                string mail = email.ToString();
                if (!(mail.StartsWith(".") || mail.StartsWith("-") || mail.StartsWith("_") || mail.EndsWith(".") || mail.EndsWith("-") || mail.EndsWith("_")))
                {
                    Console.WriteLine(email);

                }
                
            }
        }
    }
}
