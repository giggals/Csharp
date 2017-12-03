using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Hornet_Armada
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, long> legionDict = new Dictionary<string, long>();
            Dictionary<string, Dictionary<string, long>> soldierDict = new Dictionary<string, Dictionary<string, long>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split("=->: ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                int lastActivity = int.Parse(input[0]);
                string legionName = input[1];
                string soldierType = input[2];
                int soldierCount = int.Parse(input[3]);

                if (!legionDict.ContainsKey(legionName))
                {
                    soldierDict.Add(legionName, new Dictionary<string, long>());
                    legionDict.Add(legionName, lastActivity);
                }

                if (!soldierDict[legionName].ContainsKey(soldierType))
                {
                    soldierDict[legionName].Add(soldierType, soldierCount);
                }
                else
                {
                    soldierDict[legionName][soldierType] += soldierCount;
                }

                if (legionDict[legionName] < lastActivity)
                {
                    legionDict[legionName] = lastActivity;
                }
            }

            string[] command = Console.ReadLine().Split('\\');

            if (command.Length == 2)
            {
                int lastactivity = int.Parse(command[0]);
                string soldierType = command[1];


                foreach (var item in soldierDict.Where(e => soldierDict[e.Key].ContainsKey(soldierType)).OrderByDescending(x => x.Value[soldierType]))
                {
                    if (legionDict[item.Key] < lastactivity)
                    {

                        Console.WriteLine($"{item.Key} -> {item.Value[soldierType]}");
                    }

                }

            }
            else
            {
                string soldierType = command[0];
                foreach (var item in legionDict.OrderByDescending(x => x.Value))
                {
                    if (soldierDict[item.Key].ContainsKey(soldierType))
                    {
                        Console.WriteLine($"{item.Value} : {item.Key}");
                    }
                }
            }
        }
    }
}




