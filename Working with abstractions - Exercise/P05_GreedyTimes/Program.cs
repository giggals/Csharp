using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_GreedyTimes
{

    public class Potato
    {
        static void Main(string[] args)
        {
            long input = long.Parse(Console.ReadLine());
            string[] saveBox = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var purse = new Dictionary<string, Dictionary<string, long>>();
            long gold = 0;
            long stones = 0;
            long money = 0;

            for (int i = 0; i < saveBox.Length; i += 2)
            {
                string name = saveBox[i];
                long count = long.Parse(saveBox[i + 1]);

                string item = string.Empty;

                if (name.Length == 3)
                {
                    item = "Cash";
                }
                else if (name.ToLower().EndsWith("gem"))
                {
                    item = "Gem";
                }
                else if (name.ToLower() == "gold")
                {
                    item = "Gold";
                }

                if (item == "")
                {
                    continue;
                }
                else if (input < purse.Values.Select(x => x.Values.Sum()).Sum() + count)
                {
                    continue;
                }

                switch (item)
                {
                    case "Gem":
                        if (!purse.ContainsKey(item))
                        {
                            if (purse.ContainsKey("Gold"))
                            {
                                if (count > purse["Gold"].Values.Sum())
                                {
                                    continue;
                                }
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else if (purse[item].Values.Sum() + count > purse["Gold"].Values.Sum())
                        {
                            continue;
                        }
                        break;
                    case "Cash":
                        if (!purse.ContainsKey(item))
                        {
                            if (purse.ContainsKey("Gem"))
                            {
                                if (count > purse["Gem"].Values.Sum())
                                {
                                    continue;
                                }
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else if (purse[item].Values.Sum() + count > purse["Gem"].Values.Sum())
                        {
                            continue;
                        }
                        break;
                }

                if (!purse.ContainsKey(item))
                {
                    purse[item] = new Dictionary<string, long>();
                }

                if (!purse[item].ContainsKey(name))
                {
                    purse[item][name] = 0;
                }

                purse[item][name] += count;
                if (item == "Gold")
                {
                    gold += count;
                }
                else if (item == "Gem")
                {
                    stones += count;
                }
                else if (item == "Cash")
                {
                    money += count;
                }
            }

            PrintMethod(purse);
        }

        private static void PrintMethod(Dictionary<string, Dictionary<string, long>> purse)
        {
            foreach (var x in purse)
            {
                Console.WriteLine($"<{x.Key}> ${x.Value.Values.Sum()}");
                foreach (var item2 in x.Value.OrderByDescending(y => y.Key).ThenBy(y => y.Value))
                {
                    Console.WriteLine($"##{item2.Key} - {item2.Value}");
                }
            }
        }
    }
}