using System;
using System.Linq;

namespace _6._Target_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int rows = matrixSize[0];
            int cols = matrixSize[1];

            string text = Console.ReadLine();


            int[] shotParameters = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int rowsImpact = shotParameters[0];
            int columsImpact = shotParameters[1];
            int radius = shotParameters[2];

            char[,] matrix = new char[rows, cols];

            FillMethod(text, rows, cols, matrix);

            ShotFired(rowsImpact, columsImpact, radius, matrix);

            FallingDown(matrix);

            PrintMatrix(matrix);

        }

        private static char[,] FallingDown(char[,] matrix)
        {

            for (int cols = 0; cols < matrix.GetLength(1) ; cols++)
            {
                int emptyrows = 0;
                for (int rows =matrix.GetLength(0) - 1 ; rows >= 0; rows--)
                {
                    if (matrix[rows,cols] == ' ')
                    {
                        emptyrows++;
                    }
                    else if (emptyrows > 0)
                    {
                        matrix[rows + emptyrows, cols] = matrix[rows, cols];
                        matrix[rows, cols] = ' ';
                    }
                }
            }
            return matrix;
        }

        private static char[,] ShotFired(int rowsImpact, int columsImpact, int radius, char[,] matrix)
        {
            //(x - center_x)^2 + (y - center_y)^2 < radius^2

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    if ((c - columsImpact) * (c - columsImpact) + (r - rowsImpact) * (r - rowsImpact) <= radius * radius)
                    {
                        matrix[r, c] = ' ';
                    }
                }
            }

            return matrix;
        }

        private static void PrintMatrix(char[,] matrix)
        {
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    Console.Write(matrix[r, c]);
                }
                Console.WriteLine();
            }
        }

        private static char[,] FillMethod(string text, int rows, int cols, char[,] matrix)
        {
            bool isLeft = true;

            int textIndex = 0;

            for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
            {
                if (isLeft)
                {
                    for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                    {
                        if (textIndex >= text.Length)
                        {
                            textIndex = 0;
                        }

                        matrix[row, col] = text[textIndex];
                        textIndex++;
                    }
                }
                else
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        if (textIndex >= text.Length)
                        {
                            textIndex = 0;
                        }

                        matrix[row, col] = text[textIndex];
                        textIndex++;
                    }

                }
                isLeft = !isLeft;
            }
            return matrix;

        }
    }
}
