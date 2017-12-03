using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Phoenix_Oscar_Romeo_November
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            //  string[] input = Console.ReadLine().Split("->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, HashSet<string>> dict = new Dictionary<string, HashSet<string>>();
            List<string> chek = new List<string>();

            while (input != "Blaze it!")
            {
                string[] inputData = input.Split("-> ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                string creature = inputData[0];
                string squadMate = inputData[1];
                chek.Add(squadMate + "" + creature);
                     

                if (!dict.ContainsKey(creature))
                {
                    dict.Add(creature, new HashSet<string>());
                }
                
                if (creature == squadMate || chek.Contains(creature + "" + squadMate))
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
                Console.WriteLine($"{item.Key} : {item.Value.Count }");
            }

        }
    }
}
