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
            string input = Console.ReadLine();

            Dictionary<string, Dictionary<string, long>> bigDic = new Dictionary<string, Dictionary<string, long>>();
            List<string> cache = new List<string>();

            while (input != "thetinggoesskrra")
            {
                string[] command = input.Split(new[] { ' ', '-', '>', '|' },StringSplitOptions.RemoveEmptyEntries);
                
                if (command.Length == 1)
                {
                    cache.Add(command[0]);
                }

                else
                {
                    string dataKey = command[0];
                    long dataSize = long.Parse(command[1]);
                    string dataSet = command[2];

                    if (!bigDic.ContainsKey(dataSet))
                    {
                        bigDic.Add(dataSet, new Dictionary<string, long>());
                    }
                    bigDic[dataSet][dataKey] = dataSize;
                    
                }
                

                input = Console.ReadLine();
            }
            bigDic.ToList().Where(e => !cache.Contains(e.Key))
                .ToList().ForEach(e => bigDic.Remove(e.Key));


            if (bigDic.Count > 0)
            {
                var result = bigDic.OrderByDescending(x => x.Value.Sum(e => e.Value)).First();
                Console.WriteLine($"Data Set: {result.Key}, Total Size: {result.Value.Sum(e => e.Value)}");


                foreach (var item in result.Value)
                {
                    Console.WriteLine($"$.{item.Key}");
                }
            }

        }
    }
}
