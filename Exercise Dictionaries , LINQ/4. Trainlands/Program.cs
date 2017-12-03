using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Dictionary<string, Dictionary<string, int>> trainMania = new Dictionary<string, Dictionary<string, int>>();

            string inputLine = Console.ReadLine();

            while (inputLine != "It's Training Men!")
            {
                List<string> splitInput = inputLine.Split().ToList();

                string trainOne = splitInput[0];

                string trainTwo = splitInput[2];

                if (splitInput.Count() == 5)
                {
                    if (!trainMania.ContainsKey(trainOne))
                    {
                        trainMania.Add(trainOne, new Dictionary<string, int>());
                    }
                    trainMania[trainOne].Add(trainTwo, int.Parse(splitInput[4]));
                }
                else
                {
                    if (splitInput[1] == "->")
                    {
                        if (!trainMania.ContainsKey(trainOne))
                        {
                            trainMania.Add(trainOne, new Dictionary<string, int>());
                        }

                        foreach (var kvp in trainMania[trainTwo])
                        {
                            trainMania[trainOne].Add(kvp.Key, kvp.Value);
                        }

                        trainMania.Remove(trainTwo);

                    }
                    else if (splitInput[1] == "=")
                    {
                        if (!trainMania.ContainsKey(trainOne))
                        {
                            trainMania.Add(trainOne, new Dictionary<string, int>());
                        }

                        trainMania[trainOne] = new Dictionary<string, int>();

                        foreach (var kvp in trainMania[trainTwo])
                        {
                            trainMania[trainOne].Add(kvp.Key, kvp.Value);
                        }
                    }
                }

                inputLine = Console.ReadLine();
            }

            foreach (var train in trainMania
                .OrderByDescending(p => p.Value.Values.Sum())
                .ThenBy(c => c.Value.Count()))
            {
                Console.WriteLine($"Train: {train.Key}");

                foreach (var wagon in train.Value
                    .OrderByDescending(pp => pp.Value))
                {
                    Console.WriteLine($"###{wagon.Key} - {wagon.Value}");
                }
            }
        }
    }
}