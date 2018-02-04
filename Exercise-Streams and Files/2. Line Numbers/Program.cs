using System;
using System.IO;



class Program
{
    static void Main(string[] args)
    {
        using (StreamReader readFile = new StreamReader("text.txt"))
        {
            using (StreamWriter writeFile = new StreamWriter("textWithLines.txt"))
            {
                int lineIndex = 1;
                string lineReader = readFile.ReadLine();
                while (lineReader != null)
                {
                    writeFile.WriteLine($"Line {lineIndex}:{lineReader}");
                    lineIndex++;

                    lineReader = readFile.ReadLine();
                }
            }
        }
    }
}



