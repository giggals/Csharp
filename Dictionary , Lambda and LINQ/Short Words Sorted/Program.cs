﻿using System;
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
            string[] text = Console.ReadLine().ToLower().Split(": . , : ; ( ) [ ]  ' \\ / ! ? \n ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();


            var result = text.Where(w => w.Length < 5).OrderBy(w => w).Distinct();

            Console.WriteLine(string.Join(", ", result));

        }
    }
}
