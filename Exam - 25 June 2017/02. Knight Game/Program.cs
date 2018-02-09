using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Knight_Game
{
    class Program
    {

        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());

            char[][] matrix = new char[matrixSize][];

            for (int row = 0; row < matrixSize; row++)
            {
                matrix[row] = Console.ReadLine().ToCharArray();
            }

            int maxHits = 0;
            int rowIndex = 0;
            int colIndex = 0;
            int result = 0;
            
            do
            {
                if (maxHits > 0)
                {
                    matrix[rowIndex][colIndex] = '0';
                    maxHits = 0;
                    result++;
                }

                
                for (int row = 0; row < matrix.Length; row++)
                {
                    for (int col = 0; col < matrix[row].Length; col++)
                    {
                        int counter = 0;
                        
                        if (matrix[row][col] == 'K')
                        {
                            if (row - 1 >= 0 && col - 2 >= 0 && matrix[row - 1][col - 2] == 'K')
                            {
                                counter++;
                            }
                            if (row - 1 >= 0 && col + 2 < matrix.Length && matrix[row - 1][col + 2] == 'K')
                            {
                                counter++;
                              

                            }
                            if (row + 1 < matrix.Length && col - 2 >= 0 && matrix[row + 1][col - 2] == 'K')
                            {
                                counter++;
                             
                            }
                            if (row + 1 < matrix.Length && col + 2 < matrix.Length && matrix[row + 1][col + 2] == 'K')
                            {
                                counter++;
                              
                            }
                            if (row - 2 >= 0 && col - 1 >= 0 && matrix[row - 2][col - 1] == 'K')
                            {
                                counter++;
                             
                            }
                            if (row - 2 >= 0 && col + 1 < matrix.Length && matrix[row - 2][col + 1] == 'K')
                            {
                                counter++;
                              
                            }
                            if (row + 2 < matrix.Length && col - 1 >= 0 && matrix[row + 2][col - 1] == 'K')
                            {
                                counter++;
                             
                            }
                            if (row + 2 < matrix.Length && col + 1 < matrix.Length && matrix[row + 2][col + 1] == 'K')
                            {
                                counter++;
                              
                            }

                            if (counter > maxHits)
                            {
                                maxHits = counter;
                                rowIndex = row;
                                colIndex = col;
                            }
                           
                        }
                    }

                }
              
                if (matrixSize < 3)
                {
                    result = 0;
                    break;
                }


            } while (maxHits > 0);
           
           
            Console.WriteLine(result);
        }
        
    }
}
