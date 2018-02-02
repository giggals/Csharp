using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Rubik_s_Matrix
{
    class Program
    {
       

        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int numberOfCommands = int.Parse(Console.ReadLine());

          int[][]  matrix = new int[matrixSize[0]][];

            int numbers = 1;

            List<int> list = new List<int>();

            for (int rows = 0; rows < matrix.Length; rows++)
            {
                matrix[rows] = new int[matrixSize[1]];
                for (int cols = 0; cols < matrix[rows].Length; cols++)
                {
                    matrix[rows][cols] = numbers++;
                }
            }

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] commandsArgs = Console.ReadLine().Split(" ".ToString().ToCharArray());

                int colum = int.Parse(commandsArgs[0]);
                string command = commandsArgs[1];
                int moves = int.Parse(commandsArgs[2]);

                switch (command)
                {
                    case "up":
                        MoveUpDown(matrix, colum, moves);
                        break;
                    case "down":
                        MoveUpDown(matrix, colum,matrix.Length - moves % matrix.Length);
                        break;
                    case "left":
                        MoveLeftRight(matrix,colum , moves);
                        
                        break;
                    case "right":
                        MoveLeftRight(matrix, colum,matrix[0].Length - moves % matrix[0].Length);
                        break;
                }
                
            }
            var element = 1;
            for (int rows = 0; rows < matrix.Length; rows++)
            {
                for (int cols = 0; cols < matrix[0].Length; cols++)
                {
                    if (matrix[rows][cols] == element)
                    {
                        Console.WriteLine("No swap required");
                    }
                    else
                    {
                        for (int r = 0; r < matrix.Length; r++)
                        {
                            for (int c = 0; c < matrix[r].Length; c++)
                            {
                                if (matrix[r][c] == element)
                                {
                                    var currentElement = matrix[rows][cols];
                                    matrix[rows][cols] = element;
                                    matrix[r][c] = currentElement;
                                    Console.WriteLine($"Swap ({rows}, {cols}) with ({r}, {c})");
                                }
                            }
                        }
                    }
                    element++;
                }

            }
        }

        private static void MoveLeftRight(int[][] matrix ,int colums , int moves)
        {
            
            int[] array = new int[matrix[0].Length];

            for (int cols = 0; cols < matrix[0].Length; cols++)
            {
                array[cols] = matrix[colums][(cols + moves) % matrix[0].Length];
            }
            matrix[colums] = array;
          
        }

        private static void MoveUpDown(int[][] matrix ,int colums,int moves)
        {
            int[] array = new int[matrix.Length];
            for (int rows = 0; rows < matrix.Length; rows++)
            {
                array[rows] = matrix[(rows + moves) % matrix.Length][colums];    
            }
            for (int rows = 0; rows < matrix.Length; rows++)
            {
                matrix[rows][colums] = array[rows];
            }
        }
    }
}
