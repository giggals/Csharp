using System;
using System.Collections.Generic;
using System.IO;

namespace _5._Slicing_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourceFile = "sliceMe.mp4";
            string destination = "";
            int parts = 5;

            Slice(sourceFile, destination, parts);

            var list = new List<string>()
            {
                "Part-0.mp4",
                "Part-1.mp4",
                "Part-2.mp4",
                "Part-3.mp4",
                "Part-4.mp4",
            };

            Assemble(list, destination);
        }

        static void Slice(string sourceFile, string destinationDirectory, int parts)
        {
            using (FileStream reader = new FileStream(sourceFile, FileMode.Open))

            {
                var extension = sourceFile.Substring(sourceFile.LastIndexOf('.') + 1);

                var partSize = reader.Length / parts;

                if (destinationDirectory == string.Empty)
                {
                    destinationDirectory = "./";
                }


                for (int i = 0; i < parts; i++)
                {
                    int currentPieceSize = 0;

                    string currentPart = destinationDirectory + $"Part-{i}.{extension}";

                    using (FileStream writer = new FileStream(currentPart, FileMode.Create))
                    {
                        byte[] buffer = new byte[4096];

                        while (reader.Read(buffer, 0, buffer.Length) == buffer.Length)
                        {
                            writer.Write(buffer, 0, buffer.Length);
                            currentPieceSize += buffer.Length;
                            if (currentPieceSize >= partSize)
                            {
                                break;
                            }
                        }

                    }

                }
            }
        }

        static void Assemble(List<string> files, string destinationDirectory)
        {

            string extension = files[0].Substring(files[0].LastIndexOf('.') + 1);

            if (destinationDirectory == string.Empty)
            {
                destinationDirectory = "./";
            }

            string assembledFile = $"{destinationDirectory}Assembled.{extension}";

            using (FileStream writer = new FileStream(assembledFile, FileMode.Create))
            {

                foreach (var file in files)
                {
                    using (FileStream reader = new FileStream(file, FileMode.Open))
                    {
                        byte[] buffer = new byte[4096];

                        while (reader.Read(buffer, 0, buffer.Length) == 4096)
                        {
                            writer.Write(buffer, 0, buffer.Length);
                        }
                    }
                }
            }
        }
    }
}
