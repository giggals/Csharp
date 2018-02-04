using System;
using System.IO;

namespace _1._Odd_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("text.txt"))
            {
                using (StreamWriter writer = new StreamWriter("copy.txt"))
                {
                    int linenumber = 0;
                    string line = reader.ReadLine();

                    while (line != null)
                    {
                      
                        if (linenumber % 2 != 0)
                        {
                            writer.WriteLine(line);
                        }
                        linenumber++;

                        line = reader.ReadLine();
                       
                    }
                }
            }
        }
    }
}
