using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cities_by_Continent_and_Country
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, List<string>>> dict = new Dictionary<string, Dictionary<string, List<string>>>();


            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var continent = input[0];
                var country = input[1];
                var cities = input[2];

                
                    if (!dict.ContainsKey(continent))
                    {
                        dict[continent] = new Dictionary<string, List<string>>();
                    }
                if (!dict[continent].ContainsKey(country))
                {
                    dict[continent][country] = new List<string>();
                }
                
                    dict[continent][country].Add(cities);
                
                
            }
            foreach (var item in dict)
            {
                var continentName = item.Key;
                var countryName = item.Value;
                Console.WriteLine($"{continentName}:");
                foreach (var country in countryName)
                {
                    var countrys = country.Key;
                    var cities = country.Value;

                    Console.WriteLine($"  {countrys} -> {string.Join(", ",cities)}");
                }
            }
        }
    }
}
