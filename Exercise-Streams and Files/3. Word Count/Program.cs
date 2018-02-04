using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Linq;

namespace _3._Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text =
            {
                "quick",
                "is",
                "fault",
            };

         
            int counter = 0;

            Dictionary<string, int> dict = new Dictionary<string, int>();
            StreamReader textReader = new StreamReader("text.txt");
            FileStream words = new FileStream("../../log.txt", FileMode.Create);

            using (StreamWriter write = new StreamWriter("words.txt"))
            {
                int lineindex = 0;
                var lineReader = text[lineindex];
                while (text.Length > lineindex)
                {
                    write.WriteLine(text[lineindex]);

                    lineReader = text[lineindex];
                    lineindex++;
                }

            }
            using (textReader)
            {
                var readLine = textReader.ReadLine();

                while (readLine != null)
                {
                    foreach (var item in text)
                    {
                        foreach (var word in readLine.ToLower().Split(",.!-? ".ToString().ToCharArray(), StringSplitOptions.RemoveEmptyEntries))
                        {
                            if (word == item)
                            {
                                if (!dict.ContainsKey(item))
                                {
                                    dict.Add(item, counter);
                                }

                                dict[item]++;

                            }
                        }
                    }

                    readLine = textReader.ReadLine();
                }

                using (StreamWriter result = new StreamWriter("result.txt"))
                {
                    foreach (var item in dict.OrderByDescending(v => v.Value))
                    {
                        result.WriteLine($"{item.Key}-{item.Value}");
                    }
                }
                
            }
        }
    }
}
