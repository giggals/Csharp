using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Matrix_of_Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            char[,] matrix = new char[matrixSize[0], matrixSize[1]];

            List<char> alphabet = new List<char>("abcdefghijklmnopqrstuvwxyz");
            List<char> copy = new List<char>(alphabet);

            char firstLetter = ' ';
            char lastLetter = ' ';
           

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                firstLetter = copy[rows];
                lastLetter = firstLetter;


                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {

                    Console.Write($"{firstLetter}{alphabet[cols]}{lastLetter} ");

                }
                alphabet.RemoveAt(0);

                Console.WriteLine();
            }


        }
    }
}
