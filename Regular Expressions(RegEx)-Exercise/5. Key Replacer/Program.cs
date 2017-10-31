using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace P06.ValidUsernames
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string lineOfUsers = Console.ReadLine();

            string pattern = @"\b([A-Za-z]\w{2,24})\b";


            MatchCollection matchCollection = Regex.Matches(lineOfUsers, pattern);


            int bestSum = 0;
            int bestIndex = 0;


            for (int i = 0; i < matchCollection.Count - 1; i++)
            {
                string first = matchCollection[i].ToString();
                string second = matchCollection[i + 1].ToString();

                int sum = SumOfConsecutiveUsernames(first, second);
                var index = i;

                if (bestSum < sum)
                {
                    bestSum = sum;
                    bestIndex = index;
                }

            }

            Console.WriteLine(matchCollection[bestIndex]);
            Console.WriteLine(matchCollection[bestIndex + 1]);

        }

        public static int SumOfConsecutiveUsernames(string str1, string str2)
        {
            int result = 0;

            for (int i = 0; i < str1.Length; i++)
            {
                char letter = str1[i];
                result += letter;
            }
            for (int i = 0; i < str2.Length; i++)
            {
                char letter = str2[i];
                result += letter;
            }
            return result;
        }
    }
}