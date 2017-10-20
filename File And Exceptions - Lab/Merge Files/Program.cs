using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge_Files
{
    class Program
    {
        static void Main(string[] args)
        {
          string[] input1 = File.ReadAllLines("input1.txt");
           string[] input2 = File.ReadAllLines("input2.txt");

            File.WriteAllText("output.txt", "");

            string[] result = input1.Concat(input2).OrderBy(x => x).ToArray();

            foreach (var item in result)
            {
                File.AppendAllText("output.txt", item + "\r\n");
            }
        }
    }
}
