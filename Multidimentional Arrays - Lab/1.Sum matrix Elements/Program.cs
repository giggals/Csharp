using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multidimentional_Arrays___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrixSize = Console.ReadLine().Split(", ".ToString().ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            int[][] matrix = new int[int.Parse(matrixSize[0])][];

            int sum = 0;

            for (int rows = 0; rows < matrix.Length; rows++)
            {
                matrix[rows] = Console.ReadLine().Split(", ".ToString().ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int cols = 0; cols < matrix[rows].Length; cols++)
                {
                    sum += matrix[rows][cols];
                }
            }
            
        
            Console.WriteLine(matrix.Length);
            Console.WriteLine(matrix[0].Length);
            Console.WriteLine(sum);
        }
    }
}
