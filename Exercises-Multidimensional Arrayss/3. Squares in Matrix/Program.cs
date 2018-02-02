using System;
using System.Linq;

namespace _3._Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int counter = 0;

            string[][] matrix = new string[matrixSize[0]][];

            for (int rows = 0; rows < matrix.Length; rows++)
            {
                matrix[rows] = Console.ReadLine().Split(' '.ToString().ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            }

            for (int rows = 0; rows < matrix.Length - 1; rows++)
            {
                for (int cols = 0; cols < matrix[rows].Length - 1; cols++)
                {
                    if ((matrix[rows][cols] == matrix[rows][cols + 1]) && matrix[rows][cols] == matrix[rows + 1][cols] && matrix[rows][cols] == matrix[rows + 1][cols + 1])
                    {
                        counter++;
                    }

                }
            }

            Console.WriteLine(counter);
        }
    }
}
