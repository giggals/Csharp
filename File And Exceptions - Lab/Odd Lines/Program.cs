using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Odd_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("file.txt");

            var oddLines = lines.Where((line, index) => (index % 2 == 1));

            File.WriteAllLines("output.txt", oddLines);
            
        }
    }
}
