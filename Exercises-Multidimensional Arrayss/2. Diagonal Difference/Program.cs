using System;
using System.Linq;

namespace _2._Diagonal_Difference
{
    class Program
    {  
        

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[][] matrix = new int[n][];

            int firstDiagonal = 0, secondDiagonal = 0;
            int reminder = n - 1;
            

            for (int rows = 0; rows < matrix.Length; rows++)
            {
                matrix[rows] = Console.ReadLine().Split(" ".ToString().ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                
            }
            for (int cols = 0; cols < n; cols++)
            {
                firstDiagonal += matrix[cols][cols];
            }


            for (int cols = 0; cols < n; cols++)
                {
                   
                    secondDiagonal += matrix[cols][reminder];
                    reminder--;
                    
                }
            Console.WriteLine(Math.Abs(firstDiagonal - secondDiagonal));

            
        }

    }
}



