using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phoenix_Oscar_Romeo_November
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
            List<string> chek = new List<string>();

            while (input != "Blaze it!")
            {
                string[] info = input.Split("-> ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                string creature = info[0];
                string squadMate = info[1];
                chek.Add(squadMate + "" + creature);


                if (!dict.ContainsKey(creature))
                {
                    dict.Add(creature, new List<string>());
                }

                if (chek.Contains(creature + "" + squadMate) || squadMate == creature)
                {
                    dict[squadMate].Remove(creature);
                    input = Console.ReadLine();
                    continue;
                }
                dict[creature].Add(squadMate);

                input = Console.ReadLine();

            }

            foreach (var item in dict.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{item.Key} : {item.Value.Count}");
            }
        }
    }
}
