using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Evolution
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var Dictionaty = new Dictionary<string, List<string>>();
            while (input != "wubbalubbadubdub")
            {
                var tokens = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                string PokeName = tokens[0];
                if (tokens.Length > 1)
                {
                    string EvolutionType = tokens[1];
                    int Points = int.Parse(tokens[2]);
                    if (!Dictionaty.ContainsKey(PokeName))
                    {
                        Dictionaty[PokeName] = new List<string>();
                    }
                    var pointsEvolutionType = EvolutionType + " <-> " + Points;
                    Dictionaty[PokeName].Add(pointsEvolutionType);

                }
                else
                {
                    if (Dictionaty.ContainsKey(PokeName))
                    {
                        Console.WriteLine("# " + PokeName);
                        foreach (var evolution in Dictionaty[PokeName])
                        {
                            Console.WriteLine(evolution);
                        }
                    }
                }
                input = Console.ReadLine();
            }
            foreach (var item in Dictionaty)
            {
                string Name = item.Key;
                Console.WriteLine("# " + Name);
                foreach (var TypeandNumber in item.Value.OrderByDescending(x => int.Parse(x.Split(new[] { " <-> " }, StringSplitOptions.None).Skip(1).First())))
                {
                    Console.WriteLine(TypeandNumber);
                }
            }
        }
    }
}