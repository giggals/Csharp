﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
              for (int i2 = 0; i2 < n; i2++)
                    for (int i3 = 0; i3 < n; i3++)
                    {
                        char letter1 = (char)('a' + i);
                        char letter2 = (char)('a' + i2);
                        char letter3 = (char)('a' + i3);
                        Console.WriteLine($"{letter1}{letter2}{letter3}");
                    }


        }       
			
    }
}
