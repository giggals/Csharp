using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Maximum_sum_of_2x2_submatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrixSize = Console.ReadLine().Split(", ".ToString().ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            int[][] matrix = new int[int.Parse(matrixSize[0])][];
            

            int biggestSum = int.MinValue;

            int rowindex = 0;
            int colindex = 0;
            
            int currentSum = 0;

            for (int rows = 0; rows < matrix.Length; rows++)
            {
                matrix[rows] = Console.ReadLine().Split(", ".ToString().ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            }

           
            for (int rows = 0; rows < matrix.Length - 1; rows++)
            {
                for (int cols = 0; cols < matrix[rows].Length - 1; cols++)
                {
                    currentSum = matrix[rows][cols] + matrix[rows][cols + 1] + matrix[rows + 1][cols] + matrix[rows + 1][cols + 1];

                    if (biggestSum < currentSum)
                    {
                        biggestSum = currentSum;
                        rowindex = rows;
                        colindex = cols;
                    }
                }

            }
            Console.WriteLine($"{matrix[rowindex][colindex]} {matrix[rowindex][colindex + 1]}\n{matrix[rowindex+ 1][colindex]} {matrix[rowindex + 1][colindex + 1]}");
           
            
            Console.WriteLine(biggestSum);
           
        }
    }
}
