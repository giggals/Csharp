using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
         string[]  words = File.ReadAllText("words.txt").ToLower().Split();

            string[] text = File.ReadAllText("input.txt").ToLower().Split(new char[] { '\n', '\r', ' ', '.', ',', '!', '?', '-' }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            foreach (var item in words)
            {
                wordCount[item] = 0;

            }
            foreach (var word in text)
            {
                if (wordCount.ContainsKey(word))
                {
                    wordCount[word]++;
                }
               
            }
            File.WriteAllText("results.txt", "");
            foreach (var item in wordCount.OrderByDescending(w => w.Value))
            {
                File.AppendAllText("results.txt", item.Key + "-" + item.Value + Environment.NewLine);
               
            }



        }
    }
}
