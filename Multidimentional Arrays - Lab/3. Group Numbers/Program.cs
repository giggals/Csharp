using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Group_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(", ".ToString().ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int[][] jaggedArray = new int[3][];

            int[] sizes = new int[3];


            foreach (var item in input)
            {
                sizes[Math.Abs(item % 3)]++;
            }
            
            for (int i = 0; i < sizes.Length; i++)
            {
                jaggedArray[i] = new int[sizes[i]];
            }

            int[] index = new int[3];
            foreach (var item in input)
            {
                int reminder = Math.Abs(item % 3);
                jaggedArray[reminder][index[reminder]] = item;
                index[reminder]++;
            }

            for (int rows = 0; rows < jaggedArray.Length ; rows++)
            {
                for (int cols = 0; cols < jaggedArray[rows].Length; cols++)
                {
                    Console.Write(jaggedArray[rows][cols] + " ");
                }
                Console.WriteLine();
            }
         
          
        }
    }
}
