﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int min = int.MaxValue;

            for (int i = 0; i < n; i++)
            {
                int readNumbers = int.Parse(Console.ReadLine());

                if (readNumbers < min)
                {
                    min = readNumbers;
                }
            }
            Console.WriteLine(min);
        }
    }
}
