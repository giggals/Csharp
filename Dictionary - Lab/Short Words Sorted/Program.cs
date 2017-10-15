using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Short_Words_Sorted
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().ToLower().Split(new char[]
               { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' '  },
               StringSplitOptions.RemoveEmptyEntries).ToArray();

            var smallwords = new List<String>();

            foreach (var item in input)
            {
                if (item.Length < 5)
                {
                    smallwords.Add(item);
                }
                
            }
            var result = smallwords.OrderBy(x => x).Distinct();
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
