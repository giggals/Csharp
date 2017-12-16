using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _4___RainAir
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();


            Dictionary<string, List<int>> dict = new Dictionary<string, List<int>>();

            while (input != "I believe I can fly!")
            {
                string[] inputInfo = input.Split(" =".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                if (!input.Contains("="))
                {
                    string customerName = inputInfo[0];
                    int custumerFlight = int.Parse(inputInfo[1]);

                    if (!dict.ContainsKey(customerName))
                    {
                        dict.Add(customerName, new List<int>());
                    }

                    for (int i = 1; i < inputInfo.Length; i++)
                    {
                        dict[customerName].Add(int.Parse((inputInfo[i])));
                    }
                       
                }
                else
                {
                    string firstCustumer = inputInfo[0];
                    string secondCustumer = inputInfo[1];

                    dict[firstCustumer] = new List<int>(dict[secondCustumer]);
                }

                input = Console.ReadLine();
            }

            foreach (var item in dict.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                Console.WriteLine($"#{item.Key} ::: {string.Join(", ",dict[item.Key].OrderBy(x => x))}");
            }
        }
    }
}
