using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files_Directories_And__Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            File.WriteAllLines("input.txt", input);

            int maxCount = 0;
            int mostFrequent = 0;

            foreach (var item in File.ReadAllLines("input.txt"))
            {
                int num = int.Parse(item);
                int count = input.Count(c => int.Parse(c) == num);
                if (count > maxCount)
                {
                    maxCount = count;
                    mostFrequent = num;
                }
            }
            File.WriteAllText("output.txt", $"The number {mostFrequent} is the most frequent");
        }
    }
}
