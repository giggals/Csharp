using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int[][] matrix = new int[matrixSize[0]][];

            int maxSum = int.MinValue;
            
            int currentSum = 0;
            int rowIndex = 0;
            int colIndex = 0;


            for (int rows = 0; rows < matrix.Length; rows++)
            {
                matrix[rows] = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            }

            for (int rows = 0; rows < matrix.Length - 2; rows++)
            {
                for (int cols = 0; cols < matrix[rows].Length - 2; cols++)
                {
                    currentSum = matrix[rows][cols] + matrix[rows][cols + 1] + matrix[rows][cols + 2] + matrix[rows + 1][cols] + matrix[rows + 1][cols + 1] + matrix[rows + 1][cols + 2] + matrix[rows + 2][cols] + matrix[rows + 2][cols + 1] + matrix[rows + 2][cols + 2];

                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;

                        rowIndex = rows;
                        colIndex = cols;
                        
                    }
                }
            }
            Console.WriteLine($"Sum = {maxSum}");

            Console.WriteLine($"{matrix[rowIndex][colIndex]} {matrix[rowIndex][colIndex + 1]} {matrix[rowIndex][colIndex + 2]}\n{matrix[rowIndex + 1][colIndex]} {matrix[rowIndex+ 1][colIndex + 1]} {matrix[rowIndex + 1][colIndex + 2]}\n{matrix[rowIndex + 2][colIndex]} {matrix[rowIndex + 2][colIndex + 1]} {matrix[rowIndex + 2][colIndex + 2]}");

        }
    }
}
