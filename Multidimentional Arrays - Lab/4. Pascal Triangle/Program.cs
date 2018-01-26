using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
            {
            int height = int.Parse(Console.ReadLine());
            int weight = 1;

            long[][] matrix = new long[height][];

           
            for (int rows = 0; rows < height; rows++)
            {
                matrix[rows] = new long[rows + 1];

                matrix[rows][0] = 1;
                matrix[rows][rows] = 1;
                
                if (rows >= 2)
                {
                    for (int i = 1; i  < rows; i++)
                    {
                        matrix[rows][i] = matrix[rows - 1][i - 1] + matrix[rows - 1][i];
                    }
                }
            }

            for (int rows = 0; rows < matrix.Length; rows++)
            {
                for (int cols = 0; cols < matrix[rows].Length; cols++)
                {
                    Console.Write(matrix[rows][cols] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
