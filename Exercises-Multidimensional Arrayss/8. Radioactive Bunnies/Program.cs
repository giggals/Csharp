using System;
using System.Collections.Generic;
using System.Linq;


namespace _8._Radioactive_Bunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();


            char[,] matrix = new char[matrixSize[0], matrixSize[1]];
            string input;

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                input = Console.ReadLine().Trim();
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    matrix[r, c] = input[c];
                }
            }
         
            char[] commands = Console.ReadLine().ToCharArray();

            foreach (var item in commands)
            {
                switch (item)
                {
                    case 'U':
                        UpMethod(matrix);
                        break;
                    case 'D':
                        DownMethod(matrix);
                        break;
                    case 'L':
                        LeftMethod(matrix);
                        break;
                    case 'R':
                        RightMethod(matrix);
                        break;

                }
            }
        }

        private static char[,] RightMethod(char[,] matrix)
        {
            bool exit = false;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 'P')
                    {
                        matrix[row, col] = '.';
                        if (col + 1 < matrix.GetLength(1) && matrix[row,col + 1] != 'B')
                        {
                            matrix[row, col + 1] = 'P';
                        }
                        SpreadBunnies(matrix);
                        if (col + 1 >= matrix.GetLength(1))
                        {
                            for (int r = 0; r < matrix.GetLength(0); r++)
                            {
                                for (int c = 0; c < matrix.GetLength(1); c++)
                                {
                                    Console.Write(matrix[r, c]);
                                }
                                Console.WriteLine();
                            }
                            Console.WriteLine($"won: {row} {col}");
                            exit = true;
                        }


                        if (col + 1 < matrix.GetLength(1) && matrix[row, col + 1] == 'B')
                        {
                            for (int r = 0; r < matrix.GetLength(0); r++)
                            {
                                for (int c = 0; c < matrix.GetLength(1); c++)
                                {
                                    Console.Write(matrix[r, c]);
                                }
                                Console.WriteLine();
                            }
                            Console.WriteLine($"dead: {row } {col + 1}");

                        }
                        exit = true;

                    }
                    if (exit)
                    {
                        break;
                    }
                }
                if (exit)
                {
                    break;
                }
            }
            return matrix;
        }

        private static char[,] LeftMethod(char[,] matrix)
        {
           bool exit = false;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 'P')
                    {
                        matrix[row, col] = '.';
                        if (col - 1 >= 0)
                        {
                            matrix[row, col - 1] = 'P';
                        }
                        SpreadBunnies(matrix);
                        if (col - 1 < 0)
                        {
                            for (int r = 0; r < matrix.GetLength(0); r++)
                            {
                                for (int c = 0; c < matrix.GetLength(1); c++)
                                {
                                    Console.Write(matrix[r, c]);
                                }
                                Console.WriteLine();
                            }
                            Console.WriteLine($"won: {row} {col}");
                            exit = true;
                        }


                        if (col - 1 >= 0 && matrix[row, col - 1] == 'B')
                        {
                            for (int r = 0; r < matrix.GetLength(0); r++)
                            {
                                for (int c = 0; c < matrix.GetLength(1); c++)
                                {
                                    Console.Write(matrix[r, c]);
                                }
                                Console.WriteLine();
                            }
                            Console.WriteLine($"dead: {row } {col - 1}");

                        }
                        exit = true;

                    }
                    if (exit)
                    {
                        break;
                    }
                }
                if (exit)
                {
                    break;
                }

            }
            return matrix;
        }

        private static char[,] DownMethod(char[,] matrix)
        {
           bool exit = false;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 'P')
                    {
                        matrix[row, col] = '.';
                        if (row + 1 <= matrix.GetLength(0) - 1)
                        {
                            matrix[row + 1, col] = 'P';
                        }
                        SpreadBunnies(matrix);
                        if (row + 1 >= matrix.GetLength(0))
                        {
                            for (int r = 0; r < matrix.GetLength(0); r++)
                            {
                                for (int c = 0; c < matrix.GetLength(1); c++)
                                {
                                    Console.Write(matrix[r, c]);
                                }
                                Console.WriteLine();
                            }
                            Console.WriteLine($"won: {row} {col}");
                            exit = true;
                        }

                        if (row + 1 < matrix.GetLength(0) && matrix[row + 1, col] == 'B')
                        {
                            for (int r = 0; r < matrix.GetLength(0); r++)
                            {
                                for (int c = 0; c < matrix.GetLength(1); c++)
                                {
                                    Console.Write(matrix[r, c]);
                                }
                                Console.WriteLine();
                            }
                            Console.WriteLine($"dead: {row + 1} {col}");
                        }
                        exit = true;

                    }
                    if (exit)
                    {
                        break;
                    }
                }
                if (exit)
                {
                    break;
                }


            }
            return matrix;
        }

        private static char[,] UpMethod(char[,] matrix)
        {
            bool exit = false;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 'P')
                    {
                        matrix[row, col] = '.';
                        if (row - 1 >= 0)
                        {
                            matrix[row - 1, col] = 'P';
                        }
                        SpreadBunnies(matrix);
                        if (row - 1 < 0)
                        {
                            for (int r = 0; r < matrix.GetLength(0); r++)
                            {
                                for (int c = 0; c < matrix.GetLength(1); c++)
                                {
                                    Console.Write(matrix[r, c]);
                                }
                                Console.WriteLine();
                            }
                            Console.WriteLine($"won {row} {col}");
                            exit = true;
                        }

                        if (row - 1 >= 0 && matrix[row - 1, col] == 'B')
                        {
                            for (int r = 0; r < matrix.GetLength(0); r++)
                            {
                                for (int c = 0; c < matrix.GetLength(1); c++)
                                {
                                    Console.Write(matrix[r, c]);
                                }
                                Console.WriteLine();
                            }
                            Console.WriteLine($"dead: {row - 1} {col}");
                        }
                        exit = true;

                    }
                    if (exit)
                    {
                        break;
                    }

                }
                if (exit)
                {
                    break;
                }

            }
            return matrix;
        }

        private static char[,] SpreadBunnies(char[,] matrix)
        {
            List<int> list = new List<int>();

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 'B')
                    {
                        list.Add(row);
                        list.Add(col);
                    }
                }
            }
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    int firstElem = list[0];
                    int secondElem = list[1];

                    if (matrix[firstElem, secondElem] == 'B')
                    {
                        //Up
                        if (firstElem - 1 >= 0)
                        {
                            matrix[firstElem - 1, secondElem] = 'B';
                        }

                        //Down
                        if (firstElem + 1 < matrix.GetLength(0))
                        {
                            matrix[firstElem + 1, secondElem] = 'B';
                        }
                        //left
                        if (secondElem - 1 >= 0)
                        {
                            matrix[firstElem, secondElem - 1] = 'B';
                        }
                        //right
                        if (secondElem + 1 < matrix.GetLength(1))
                        {
                            matrix[firstElem, secondElem + 1] = 'B';
                        }
                        list.RemoveAt(0);
                        list.RemoveAt(0);
                    }
                    if (list.Count == 0)
                    {
                        break;
                    }

                }
                if (list.Count == 0)
                {
                    break;
                }
            }
            return matrix;

        }
        
    }
}
