using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _7._Directory_Traversal
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Console.ReadLine();

            Dictionary<string,List<FileInfo>> dict = new Dictionary<string, List<FileInfo>>();

            var files = Directory.GetFiles(path);

            foreach (var file in files)
            {
                var fileInfo = new FileInfo(file);

                string extension = fileInfo.Extension;

                if (!dict.ContainsKey(extension))
                {
                    dict[extension] = new List<FileInfo>();
                }

                dict[extension].Add(fileInfo);
            }


            dict = dict.OrderByDescending(x => x.Value.Count).
                ThenBy(x => x.Key).
                ToDictionary(x => x.Key, y => y.Value);

            var dekstop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string fullFileName = dekstop + "/report.txt";

            using (StreamWriter writer = new StreamWriter(fullFileName))
            {
                foreach (var item in dict)
                {
                    var extension = item.Key;
                    var fileInfo = item.Value.OrderByDescending(f => f.Length);


                    writer.WriteLine(extension);

                    foreach (var file in fileInfo)
                    {
                        writer.WriteLine($"--{file.Name} - {(double)file.Length / 1024}kb");
                    }
                    
                }
            }

        }
    }
}
