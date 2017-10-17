using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Dictionary<string, string> dict = new Dictionary<string, string>();

            while (true)
            {
                string key = Console.ReadLine();

                if (key == "stop")
                {
                    break;
                }
                else
                {
                    dict[key] = Console.ReadLine();
                }
                
            }
            foreach (KeyValuePair <string,string> kvp in dict)
            {
                if (!kvp.Value.EndsWith("us") && !kvp.Value.EndsWith("uk"))
                {
                    Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
                }
            }
        }
    }
}
